using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.Framework.Gwen.ControlInternal;
using Intersect.Client.General;
using Intersect.Client.Networking;
using Intersect.Enums;
using Newtonsoft.Json;
using System;

namespace Intersect.Client.Interface.Game
{

    public class PopupWindow
    {
        public static readonly string DEFAULT_POPUP = "popup_window.png";

        //Controls
        private Canvas mGameCanvas;

        private ImagePanel mPopupWindow;

        private ScrollControl mPopupTextArea;

        private Label mPopupTitle;

        private Button mCloseButton;

        private ImagePanel mPopupFace;

        private Label mPopupTextLabelTemplate;

        private RichLabel mPopupTextLabel;

        //Properties
        private long DisplayTime = 0;

        public PopupWindow(Canvas gameCanvas)
        {
            //Popup Window
            mGameCanvas = gameCanvas;

            mPopupWindow = new ImagePanel(gameCanvas, "PopupWindow");
            
            //Interface.InputBlockingElements.Add(mPopupWindow);

            mPopupTitle = new Label(mPopupWindow, "PopupTitle");

            mCloseButton = new Button(mPopupWindow, "CloseButton");
            mCloseButton.Clicked += CloseButton_Clicked;

            mPopupFace = new ImagePanel(mPopupWindow, "PopupFace");

            mPopupTextArea = new ScrollControl(mPopupWindow, "PopupTextArea");
            mPopupTextLabelTemplate = new Label(mPopupTextArea, "PopupTextLabel");
            mPopupTextLabel = new RichLabel(mPopupTextArea);
            mPopupWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
            mPopupWindow.Hide();
        }

        

        public void Setup(string picture, string title, string text, byte opacity, string face, sbyte[] popupLayout)
        {
            var transparency = Color.FromArgb(opacity, 255, 255, 255);
            if (string.IsNullOrEmpty(picture))
            {
                mPopupWindow.Texture = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Gui, DEFAULT_POPUP);
            }
            else
            {
                mPopupWindow.Texture = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Image, picture);
            }
            if (mPopupWindow.Texture != null)
            {
                //Setup popup window
                mPopupWindow.RenderColor = transparency;
                //mCloseButton.RenderColor = transparency;
                mPopupWindow.SetSize(mPopupWindow.Texture.GetWidth(), mPopupWindow.Texture.GetHeight());
                Align.Center(mPopupWindow);

                //Setup title if needed
                if (string.IsNullOrEmpty(title))
                {
                    mPopupTitle.Hide();
                }
                else
                {
                    mPopupTitle.Text = title;
                    mPopupTitle.Show();
                    Align.Center(mPopupTitle);
                }

                //Setup face if needed
                if (string.IsNullOrEmpty(face))
                {
                    mPopupFace.Texture = null;
                    mPopupFace.Hide();
                }
                else
                {
                    mPopupFace.Texture = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Face, face);
                    if (mPopupFace.Texture != null)
                    {
                        mPopupFace.SetSize(mPopupFace.Texture.GetWidth(), mPopupFace.Texture.GetHeight());
                        mPopupFace.Show();
                        Align.Center(mPopupFace);
                    }
                    else
                    {
                        mPopupFace.Hide();
                    }
                }

                //Setup text area if needed
                if (string.IsNullOrEmpty(text))
                {
                    mPopupTextArea.Hide();
                }
                else
                {
                    mPopupTextArea.SetSize((int)(mPopupWindow.Width * (popupLayout[((int)PopupLayoutParams.TextAreaWidth)] / 100.0f)),
                    (int)(mPopupWindow.Height * (popupLayout[((int)PopupLayoutParams.TextAreaHeight)] / 100.0f))
                    );
                    mPopupTextArea.Show();
                    Align.Center(mPopupTextArea);
                    mPopupTextLabel.ClearText();
                    mPopupTextLabel.Width = mPopupTextArea.Width -
                                                    mPopupTextArea.GetVerticalScrollBar().Width;

                    mPopupTextLabel.AddText(
                       text, mPopupTextLabelTemplate.TextColor,
                        mPopupTextLabelTemplate.CurAlignments.Count > 0
                            ? mPopupTextLabelTemplate.CurAlignments[0]
                            : Alignments.Left, mPopupTextLabelTemplate.Font
                    );

                    mPopupTextLabel.SizeToChildren(false, true);
                    mPopupTextArea.ScrollToTop();
                    if (mPopupTextLabel.Height > mPopupTextArea.Height)
                    {
                        mPopupTextArea.GetVerticalScrollBar().Show();
                    }
                    else
                    {
                        mPopupTextArea.GetVerticalScrollBar().Hide();
                    }
                    mPopupTextArea.GetVerticalScrollBar().Children.ForEach(child =>
                    {
                        child.RenderColor = transparency;
                    });
                    mPopupTextArea.GetVerticalScrollBar().RenderColor = transparency;
                }
                
                // Process alignements and then adjust positions
                mPopupWindow.ProcessAlignments();
                mPopupWindow.SetPosition(mPopupWindow.X + mGameCanvas.Width * (popupLayout[((int)PopupLayoutParams.PopupShiftX)]/100.0f),
                    mPopupWindow.Y + mGameCanvas.Height * (popupLayout[((int)PopupLayoutParams.PopupShiftY)] / 100.0f)
                    );
                // Adjust if out of the gameui depending on resolution
                if (mPopupWindow.X < 0)
                {
                    mPopupWindow.SetPosition(0, mPopupWindow.Y);
                }
                if (mPopupWindow.X + mPopupWindow.Width > mGameCanvas.Width)
                {
                    mPopupWindow.SetPosition(mGameCanvas.Width - mPopupWindow.Width, mPopupWindow.Y);
                }
                if (mPopupWindow.Y < 0)
                {
                    mPopupWindow.SetPosition(mPopupWindow.X, 0);
                }
                if (mPopupWindow.Y + mPopupWindow.Height > mGameCanvas.Height)
                {
                    mPopupWindow.SetPosition(mPopupWindow.X, mGameCanvas.Height - mPopupWindow.Height);
                }
                mPopupTitle.SetPosition(mPopupTitle.X + mPopupWindow.Width * (popupLayout[((int)PopupLayoutParams.TitleShiftX)] / 100.0f),
                    mPopupTitle.Y + mPopupWindow.Height * (popupLayout[((int)PopupLayoutParams.TitleShiftY)] / 100.0f)
                    );
                mPopupFace.SetPosition(mPopupFace.X + mPopupWindow.Width * (popupLayout[((int)PopupLayoutParams.FaceShiftX)] / 100.0f),
                    mPopupFace.Y + mPopupWindow.Height * (popupLayout[((int)PopupLayoutParams.FaceShiftY)] / 100.0f)
                    );
                mPopupTextArea.SetPosition(mPopupTextArea.X + mPopupWindow.Width * (popupLayout[((int)PopupLayoutParams.TextAreaShiftX)] / 100.0f),
                    mPopupTextArea.Y + mPopupWindow.Height * (popupLayout[((int)PopupLayoutParams.TextAreaShiftY)] / 100.0f)
                    );

                mPopupWindow.BringToFront();
                mPopupWindow.Show();
                DisplayTime = Globals.System.GetTimeMs();
            }
            else
            {
                Close();
            }
        }

        private void CloseButton_Clicked(Base sender, ClickedEventArgs arguments)
        {
            Close();
        }

        public void Close()
        {
            if (mPopupWindow.IsVisible)
            {
                if (Globals.Popups.Count > 0)
                {
                    Globals.Popups.RemoveAt(0);
                }
                mPopupWindow.Hide();
            }
        }

        public void Update()
        {
            if (mPopupWindow.IsVisible && Globals.Popups.Count > 0)
            {
                var popup = Globals.Popups[0];
                if (popup.HideTime > 0 && Globals.System.GetTimeMs() > DisplayTime + popup.HideTime)
                {
                    //Should auto close this picture
                    Close();
                }
            }
        }
    }

}
