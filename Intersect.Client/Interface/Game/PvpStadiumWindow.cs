using System;

using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Client.Networking;

namespace Intersect.Client.Interface.Game
{

    class PvpStadiumWindow
    {
        //Controls
        private WindowControl mStadiumWindow;

        private RichLabel mDescription;
        private Label mDescriptionText;
        private Button mToggleRegistrationButton;
        private Label mStatus;
        private Label mInfos;
        private Label mVictories;
        private Label mDefeats;

        //Init
        public PvpStadiumWindow(Canvas gameCanvas)
        {
            mStadiumWindow = new WindowControl(gameCanvas, Strings.PvpStadium.title, false, "PvpStadiumWindow");
            mStadiumWindow.DisableResizing();

            mDescription = new RichLabel(mStadiumWindow, "DescriptionLabel");
            mDescriptionText = new Label(mStadiumWindow, "DescriptionText");
            mDescriptionText.IsHidden = true;
            //mDescriptionText.Font = mDescriptionText.Parent.Skin.DefaultFont;

            mStatus = new Label(mStadiumWindow, "StatusLabel");
            mStatus.SetText(Strings.PvpStadium.status.ToString("Match accepté"));

            mToggleRegistrationButton = new Button(mStadiumWindow, "ToggleRegistrationButton");
            mToggleRegistrationButton.SetText(Strings.PvpStadium.register);
            mToggleRegistrationButton.Clicked += toggleRegistrationButton_Clicked;

            mInfos = new Label(mStadiumWindow, "InfosLabel");
            mInfos.SetText(Strings.PvpStadium.infos);

            mVictories = new Label(mStadiumWindow, "VictoriesLabel");
            mVictories.SetText(Strings.PvpStadium.victories.ToString("3"));

            mDefeats = new Label(mStadiumWindow, "DefeatsLabel");
            mDefeats.SetText(Strings.PvpStadium.defeats.ToString("1"));

            //UpdateList();

            mStadiumWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

            mDescription.AddText(Strings.PvpStadium.description, mDescription.RenderColor,
                mDescriptionText.CurAlignments.Count > 0 ? mDescriptionText.CurAlignments[0] : Alignments.Left, mDescriptionText.Font);
        }

        //Methods
        public void Update()
        {
            if (mStadiumWindow.IsHidden)
            {
                return;
            }
        }

        public void Show()
        {
            mStadiumWindow.IsHidden = false;
        }

        public bool IsVisible()
        {
            return !mStadiumWindow.IsHidden;
        }

        public void Hide()
        {
            mStadiumWindow.IsHidden = true;
        }

        /*public void UpdateList()
        {
            //Clear previous instances if already existing
            if (mFriends != null)
            {
                mFriends.Clear();
            }

            foreach (var f in Globals.Me.Friends)
            {
                var row = f.Online ? mFriends.AddRow(f.Name + " - " + f.Map) : mFriends.AddRow(f.Name);
                row.UserData = f.Name;
                row.Clicked += friends_Clicked;
                row.RightClicked += friends_RightClicked;

                //Row Render color (red = offline, green = online)
                if (f.Online == true)
                {
                    row.SetTextColor(Color.Green);
                }
                else
                {
                    row.SetTextColor(Color.Red);
                }

                row.RenderColor = new Color(50, 255, 255, 255);
            }
        }*/

        void toggleRegistrationButton_Clicked(Base sender, ClickedEventArgs arguments)
        {
            if (mToggleRegistrationButton.Text == Strings.PvpStadium.register)
            {
                mToggleRegistrationButton.SetText(Strings.PvpStadium.unregister);
            }
            else
            {
                mToggleRegistrationButton.SetText(Strings.PvpStadium.register);
            }
        }


    }

}
