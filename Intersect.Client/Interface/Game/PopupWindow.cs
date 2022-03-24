using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.Framework.Gwen.ControlInternal;
using Intersect.Client.General;
using Intersect.Client.Networking;
using System;

namespace Intersect.Client.Interface.Game
{

    class PopupWindow
    {
        public static readonly string DEFAULT_POPUP = "popup_window.png";

        //Controls
        private Canvas mGameCanvas;

        private ImagePanel mPopupWindow;

        private ScrollControl mPopupTextArea;

        private Label mPopupTitle;

        private Button mCloseButton;

        private Label mPopupTextLabelTemplate;

        private RichLabel mPopupTextLabel;

        //Properties
        public string Picture { get; private set; }
        public string Title { get; private set; }
        public string Text { get; private set; }
        public byte Opacity { get; private set; }

        public PopupWindow(Canvas gameCanvas)
        {
            //Popup Window
            mGameCanvas = gameCanvas;

            mPopupWindow = new ImagePanel(gameCanvas, "PopupWindow");
            
            //Interface.InputBlockingElements.Add(mPopupWindow);

            mPopupTitle = new Label(mPopupWindow, "PopupTitle");

            mCloseButton = new Button(mPopupWindow, "CloseButton");
            mCloseButton.Clicked += CloseButton_Clicked;

            mPopupTextArea = new ScrollControl(mPopupWindow, "PopupTextArea");
            mPopupTextLabelTemplate = new Label(mPopupTextArea, "PopupTextLabel");
            mPopupTextLabel = new RichLabel(mPopupTextArea);

            mPopupWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
            mPopupWindow.Hide();
        }

        

        public void Setup(string picture, string title, string text, byte opacity)
        {
            Picture = picture;
            Title = title;
            Text = text;
            Opacity = opacity;
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
                mPopupWindow.SetSize(mPopupWindow.Texture.GetWidth(), mPopupWindow.Texture.GetHeight());
                Align.Center(mPopupWindow);

                mPopupTextArea.SetSize((int)(mPopupWindow.Width * 0.9), (int)(mPopupWindow.Height * 0.7));
                Align.CenterHorizontally(mPopupTextArea);

                mPopupTitle.Text = title;

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
                var transparency = Color.FromArgb(opacity, 255, 255, 255);
                mPopupWindow.RenderColor = transparency;
                mPopupTextArea.GetVerticalScrollBar().GetScrollBarButton(Pos.Top).RenderColor = transparency;
                mPopupTextArea.GetVerticalScrollBar().GetScrollBarButton(Pos.Bottom).RenderColor = transparency;
                mPopupTextArea.GetVerticalScrollBar().RenderColor = transparency;
                mCloseButton.RenderColor = transparency;
                mPopupWindow.ProcessAlignments();
                mPopupWindow.BringToFront();
                mPopupWindow.Show();
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
                //PacketSender.SendClosePicture(Globals.Picture?.EventId ?? Guid.Empty);
                Globals.Popup = null;
                Picture = null;
                Title = null;
                Text = null;
                mPopupWindow.Hide();
            }
        }

        public void Update()
        {
            if (mPopupWindow.IsVisible)
            {
                if (Globals.Popup != null && Globals.Popup.HideTime > 0 && Globals.System.GetTimeMs() > Globals.Popup.ReceiveTime + Globals.Popup.HideTime)
                {
                    //Should auto close this picture
                    Close();
                }
            }
        }
    }

}
