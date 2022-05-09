using Intersect.Client.Core;
using Intersect.Client.Entities;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.Framework.Gwen.ControlInternal;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Client.Networking;
using Intersect.Enums;
using Newtonsoft.Json;
using System;
using Label = Intersect.Client.Framework.Gwen.Control.Label;

namespace Intersect.Client.Interface.Game.EntityPanel
{

    public class ExpBoostsWindow
    {
        //Controls
        private Canvas mGameCanvas;

        private ImagePanel mExpBoostsWindow;

        private Label mExpBoostsTitle;

        private Label mPlayerTargetLabel;
        private Label mPlayerExpBoostTitleLabel;
        private Label mPlayerExpBoostValuesLabel;

        private Label mPartyTargetLabel;
        private Label mPartyExpBoostTitleLabel;
        private Label mPartyExpBoostValuesLabel;

        private Label mGuildTargetLabel;
        private Label mGuildExpBoostTitleLabel;
        private Label mGuildExpBoostValuesLabel;

        private Label mAllPlayersTargetLabel;
        private Label mAllPlayersExpBoostTitleLabel;
        private Label mAllPlayersExpBoostValuesLabel;


        public ExpBoostsWindow(Canvas gameCanvas)
        {
            //Popup Window
            mGameCanvas = gameCanvas;

            mExpBoostsWindow = new ImagePanel(gameCanvas, "ExpBoostsWindow");

            mExpBoostsTitle = new Label(mExpBoostsWindow, "ExpBoostsTitle");
            mExpBoostsTitle.Text = Strings.ExpBoosts.title;

            mPlayerTargetLabel = new Label(mExpBoostsWindow, "PlayerTargetLabel");
            mPlayerTargetLabel.Text = Strings.ExpBoosts.personnal;
            mPlayerExpBoostTitleLabel = new Label(mExpBoostsWindow, "PlayerExpBoostTitleLabel");
            mPlayerExpBoostValuesLabel = new Label(mExpBoostsWindow, "PlayerExpBoostValuesLabel");

            mPartyTargetLabel = new Label(mExpBoostsWindow, "PartyTargetLabel");
            mPartyTargetLabel.Text = Strings.ExpBoosts.party;
            mPartyExpBoostTitleLabel = new Label(mExpBoostsWindow, "PartyExpBoostTitleLabel");
            mPartyExpBoostValuesLabel = new Label(mExpBoostsWindow, "PartyExpBoostValuesLabel");

            mGuildTargetLabel = new Label(mExpBoostsWindow, "GuildTargetLabel");
            mGuildTargetLabel.Text = Strings.ExpBoosts.guild;
            mGuildExpBoostTitleLabel = new Label(mExpBoostsWindow, "GuildExpBoostTitleLabel");
            mGuildExpBoostValuesLabel = new Label(mExpBoostsWindow, "GuildExpBoostValuesLabel");

            mAllPlayersTargetLabel = new Label(mExpBoostsWindow, "AllPlayersTargetLabel");
            mAllPlayersTargetLabel.Text = Strings.ExpBoosts.allplayers;
            mAllPlayersExpBoostTitleLabel = new Label(mExpBoostsWindow, "AllPlayersExpBoostTitleLabel");
            mAllPlayersExpBoostValuesLabel = new Label(mExpBoostsWindow, "AllPlayersExpBoostValuesLabel");

            mExpBoostsWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
            mExpBoostsWindow.Hide();
        }

        public void Show()
        {
            mExpBoostsWindow.Show();
            mExpBoostsWindow.BringToFront();
        }

        public void Hide()
        {
            mExpBoostsWindow.Hide();
        }

        public void Update()
        {
            if (mExpBoostsWindow.IsVisible)
            {
                var now = Globals.System.GetTimeMs();
                if (ExpBoost.PlayerExpBoost != null)
                {
                    string txtValues = "";
                    mPlayerExpBoostTitleLabel.Text = Strings.ExpBoosts.playertitle.ToString(
                        ExpBoost.PlayerExpBoost.Title, ExpBoost.PlayerExpBoost.SourcePlayerName);
                    if (ExpBoost.PlayerExpBoost.AmountKill > 0)
                    {
                        txtValues += Strings.ExpBoosts.playerkillvalues.ToString(
                            ExpBoost.PlayerExpBoost.AmountKill, HourMinSecFormat(ExpBoost.PlayerExpBoost.ExpireTimeKill - now));
                    }
                    if (ExpBoost.PlayerExpBoost.AmountQuest > 0)
                    {
                        txtValues += Strings.ExpBoosts.playerquestvalues.ToString(
                            ExpBoost.PlayerExpBoost.AmountQuest, HourMinSecFormat(ExpBoost.PlayerExpBoost.ExpireTimeQuest - now));
                    }
                    mPlayerExpBoostValuesLabel.Text = txtValues;
                }
                else
                {
                    mPlayerExpBoostTitleLabel.Text = "";
                    mPlayerExpBoostValuesLabel.Text = "";
                }

                if (ExpBoost.PartyExpBoost != null)
                {
                    string txtValues = "";
                    mPartyExpBoostTitleLabel.Text = Strings.ExpBoosts.partytitle.ToString(
                        ExpBoost.PartyExpBoost.Title, ExpBoost.PartyExpBoost.SourcePlayerName);
                    if (ExpBoost.PartyExpBoost.AmountKill > 0)
                    {
                        txtValues += Strings.ExpBoosts.partykillvalues.ToString(
                            ExpBoost.PartyExpBoost.AmountKill, HourMinSecFormat(ExpBoost.PartyExpBoost.ExpireTimeKill - now));
                    }
                    if (ExpBoost.PartyExpBoost.AmountQuest > 0)
                    {
                        txtValues += Strings.ExpBoosts.partyquestvalues.ToString(
                            ExpBoost.PartyExpBoost.AmountQuest, HourMinSecFormat(ExpBoost.PartyExpBoost.ExpireTimeQuest - now));
                    }
                    mPartyExpBoostValuesLabel.Text = txtValues;
                }
                else
                {
                    mPartyExpBoostTitleLabel.Text = "";
                    mPartyExpBoostValuesLabel.Text = "";
                }

                if (ExpBoost.GuildExpBoost != null)
                {
                    string txtValues = "";
                    mGuildExpBoostTitleLabel.Text = Strings.ExpBoosts.guildtitle.ToString(
                        ExpBoost.GuildExpBoost.Title, ExpBoost.GuildExpBoost.SourcePlayerName);
                    if (ExpBoost.GuildExpBoost.AmountKill > 0)
                    {
                        txtValues += Strings.ExpBoosts.guildkillvalues.ToString(
                            ExpBoost.GuildExpBoost.AmountKill, HourMinSecFormat(ExpBoost.GuildExpBoost.ExpireTimeKill - now));
                    }
                    if (ExpBoost.GuildExpBoost.AmountQuest > 0)
                    {
                        txtValues += Strings.ExpBoosts.guildquestvalues.ToString(
                            ExpBoost.GuildExpBoost.AmountQuest, HourMinSecFormat(ExpBoost.GuildExpBoost.ExpireTimeQuest - now));
                    }
                    mGuildExpBoostValuesLabel.Text = txtValues;
                }
                else
                {
                    mGuildExpBoostTitleLabel.Text = "";
                    mGuildExpBoostValuesLabel.Text = "";
                }

                if (ExpBoost.AllExpBoost != null)
                {
                    string txtValues = "";
                    mAllPlayersExpBoostTitleLabel.Text = Strings.ExpBoosts.allplayerstitle.ToString(
                        ExpBoost.AllExpBoost.Title, ExpBoost.AllExpBoost.SourcePlayerName);
                    if (ExpBoost.AllExpBoost.AmountKill > 0)
                    {
                        txtValues += Strings.ExpBoosts.allplayerskillvalues.ToString(
                            ExpBoost.AllExpBoost.AmountKill, HourMinSecFormat(ExpBoost.AllExpBoost.ExpireTimeKill - now));
                    }
                    if (ExpBoost.AllExpBoost.AmountQuest > 0)
                    {
                        txtValues += Strings.ExpBoosts.allplayersquestvalues.ToString(
                            ExpBoost.AllExpBoost.AmountQuest, HourMinSecFormat(ExpBoost.AllExpBoost.ExpireTimeQuest - now));
                    }
                    mAllPlayersExpBoostValuesLabel.Text = txtValues;
                }
                else
                {
                    mAllPlayersExpBoostTitleLabel.Text = "";
                    mAllPlayersExpBoostValuesLabel.Text = "";
                }
            }
        }

        private static string HourMinSecFormat(long msTime)
        {
            int seconds = (int)(msTime / 1000) % 60;
            int minutes = (int)((msTime / (1000 * 60)) % 60);
            int hours = (int)((msTime / (1000 * 60 * 60)) % 24);
            return Strings.ExpBoosts.hourminsecformat.ToString(hours, minutes, seconds);
        }
    }

}
