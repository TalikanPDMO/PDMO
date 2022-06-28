using System;

using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Client.Networking;
using Intersect.Enums;

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
        private Label mWins;
        private Label mLosses;

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
            //mStatus.SetText(Strings.PvpStadium.status.ToString("Match accepté"));

            mToggleRegistrationButton = new Button(mStadiumWindow, "ToggleRegistrationButton");
            mToggleRegistrationButton.SetText(Strings.PvpStadium.register);
            mToggleRegistrationButton.Clicked += toggleRegistrationButton_Clicked;

            mInfos = new Label(mStadiumWindow, "InfosLabel");
            mInfos.SetText(Strings.PvpStadium.infos);

            mWins = new Label(mStadiumWindow, "WinsLabel");
            //mWins.SetText(Strings.PvpStadium.wins.ToString("3"));

            mLosses = new Label(mStadiumWindow, "LossesLabel");
            //mLosses.SetText(Strings.PvpStadium.losses.ToString("1"));

            mStadiumWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

            mDescription.AddText(Strings.PvpStadium.description, mDescription.RenderColor,
                mDescriptionText.CurAlignments.Count > 0 ? mDescriptionText.CurAlignments[0] : Alignments.Left, mDescriptionText.Font);

            PacketSender.SendTogglePvpStadium(true);
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

        public void UpdateInfos()
        {
            switch(Globals.Me.StadiumState)
            {
                case PvpStadiumState.Unregistred:
                    mToggleRegistrationButton.SetText(Strings.PvpStadium.register);
                    mToggleRegistrationButton.Show();
                    break;
                case PvpStadiumState.None:
                    mToggleRegistrationButton.SetText(Strings.PvpStadium.unregister);
                    mToggleRegistrationButton.Show();
                    break;
                case PvpStadiumState.MatchAccepted:
                case PvpStadiumState.MatchOnGoing:
                case PvpStadiumState.MatchOnPreparation:
                    mToggleRegistrationButton.SetText(Strings.PvpStadium.abandon);
                    mToggleRegistrationButton.Show();
                    break;
                case PvpStadiumState.MatchEnded:
                    mToggleRegistrationButton.Hide();
                    break;
            }
            mStatus.SetText(Strings.PvpStadium.status.ToString(Strings.PvpStadium.StadiumStates[Globals.Me.StadiumState]));
            mWins.SetText(Strings.PvpStadium.wins.ToString(Globals.Me.StadiumWins));
            mLosses.SetText(Strings.PvpStadium.losses.ToString(Globals.Me.StadiumLosses));
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
            PacketSender.SendTogglePvpStadium();
        }


    }

}
