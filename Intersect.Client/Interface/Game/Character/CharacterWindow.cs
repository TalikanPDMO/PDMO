﻿using System;
using System.Collections.Generic;

using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.Client.Networking;
using Intersect.Enums;
using Intersect.GameObjects;

namespace Intersect.Client.Interface.Game.Character
{

    public class CharacterWindow
    {

        //Equipment List
        public List<EquipmentItem> Items = new List<EquipmentItem>();

        Label mAbilityPwrLabel;

        Button mAddAbilityPwrBtn;

        Button mAddAttackBtn;

        Button mAddDefenseBtn;

        Button mAddMagicResistBtn;

        // Not possible to invest stats in speed
        //Button mAddSpeedBtn;

        //Stats
        Label mAttackLabel;

        private ImagePanel mCharacterContainer;

        private Label mCharacterInfos;

        private Label mCharacterName;

        private ImagePanel mCharacterPortrait;

        private string mCharacterPortraitImg = "";

        //Controls
        private WindowControl mCharacterWindow;

        private string mCurrentSprite = "";

        Label mStatsLabel;

        Label mDefenseLabel;

        private int[] mEmptyStatBoost = new int[(int)Stats.StatCount];

        private List<int[]> mEmptyEffects = new List<int[]>();

        Label mMagicRstLabel;

        Label mAttackSpeedLabel;

        Label mSpeedLabel;

        public ImagePanel[] PaperdollPanels;

        public string[] PaperdollTextures;

        //Location
        public int X;

        public int Y;

        //Init
        public CharacterWindow(Canvas gameCanvas)
        {
            mCharacterWindow = new WindowControl(gameCanvas, Strings.Character.title, false, "CharacterWindow");
            mCharacterWindow.DisableResizing();

            mCharacterName = new Label(mCharacterWindow, "CharacterNameLabel");
            mCharacterName.SetTextColor(Color.White, Label.ControlState.Normal);

            mCharacterInfos = new Label(mCharacterWindow, "ChatacterInfoLabel");
            mCharacterInfos.SetText("");

            mCharacterContainer = new ImagePanel(mCharacterWindow, "CharacterContainer");

            mCharacterPortrait = new ImagePanel(mCharacterContainer);

            PaperdollPanels = new ImagePanel[Options.EquipmentSlots.Count + 1];
            PaperdollTextures = new string[Options.EquipmentSlots.Count + 1];
            for (var i = 0; i <= Options.EquipmentSlots.Count; i++)
            {
                PaperdollPanels[i] = new ImagePanel(mCharacterContainer);
                PaperdollTextures[i] = "";
                PaperdollPanels[i].Hide();
            }

            var equipmentLabel = new Label(mCharacterWindow, "EquipmentLabel");
            equipmentLabel.SetText(Strings.Character.equipment);

            mStatsLabel = new Label(mCharacterWindow, "StatsLabel");

            mAttackLabel = new Label(mCharacterWindow, "AttackLabel");
            mAttackLabel.SetToolTipText(Strings.Character.stat0desc);
            
            mAddAttackBtn = new Button(mCharacterWindow, "IncreaseAttackButton");
            mAddAttackBtn.Clicked += _addAttackBtn_Clicked;

            mDefenseLabel = new Label(mCharacterWindow, "DefenseLabel");
            mDefenseLabel.SetToolTipText(Strings.Character.stat1desc);
            mAddDefenseBtn = new Button(mCharacterWindow, "IncreaseDefenseButton");
            mAddDefenseBtn.Clicked += _addDefenseBtn_Clicked;

            mSpeedLabel = new Label(mCharacterWindow, "SpeedLabel");
            mSpeedLabel.SetToolTipText(Strings.Character.stat4desc);
            //mAddSpeedBtn = new Button(mCharacterWindow, "IncreaseSpeedButton");
            //mAddSpeedBtn.Clicked += _addSpeedBtn_Clicked;

            mAbilityPwrLabel = new Label(mCharacterWindow, "AbilityPowerLabel");
            mAbilityPwrLabel.SetToolTipText(Strings.Character.stat2desc);
            mAddAbilityPwrBtn = new Button(mCharacterWindow, "IncreaseAbilityPowerButton");
            mAddAbilityPwrBtn.Clicked += _addAbilityPwrBtn_Clicked;

            mMagicRstLabel = new Label(mCharacterWindow, "MagicResistLabel");
            mMagicRstLabel.SetToolTipText(Strings.Character.stat3desc);
            mAddMagicResistBtn = new Button(mCharacterWindow, "IncreaseMagicResistButton");
            mAddMagicResistBtn.Clicked += _addMagicResistBtn_Clicked;

            mAttackSpeedLabel = new Label(mCharacterWindow, "AttackSpeedLabel");
            mAttackSpeedLabel.SetToolTipText(Strings.Character.attackspeeddesc);

            for (var i = 0; i < Options.EquipmentSlots.Count; i++)
            {
                Items.Add(new EquipmentItem(i, mCharacterWindow));
                Items[i].Pnl = new ImagePanel(mCharacterWindow, "EquipmentItem" + i);
                Items[i].Setup();
            }

            mCharacterWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
        }

        //Update Button Event Handlers
        void _addMagicResistBtn_Clicked(Base sender, ClickedEventArgs arguments)
        {
            PacketSender.SendUpgradeStat((int) Stats.MagicResist);
        }

        void _addAbilityPwrBtn_Clicked(Base sender, ClickedEventArgs arguments)
        {
            PacketSender.SendUpgradeStat((int) Stats.AbilityPower);
        }

        // Not possible to invest stats in speed
        //void _addSpeedBtn_Clicked(Base sender, ClickedEventArgs arguments)
        //{
        //    PacketSender.SendUpgradeStat((int) Stats.Speed);
        //}

        void _addDefenseBtn_Clicked(Base sender, ClickedEventArgs arguments)
        {
            PacketSender.SendUpgradeStat((int) Stats.Defense);
        }

        void _addAttackBtn_Clicked(Base sender, ClickedEventArgs arguments)
        {
            PacketSender.SendUpgradeStat((int) Stats.Attack);
        }

        //Methods
        public void Update()
        {
            if (mCharacterWindow.IsHidden)
            {
                return;
            }

            mCharacterName.Text = Strings.Character.nameandinfos.ToString(Globals.Me.Name, ClassBase.GetName(Globals.Me.Class), Globals.Me.Level);
            if (Globals.Me.ElementalTypes != null)
            {
                if (Globals.Me.ElementalTypes[0] == Globals.Me.ElementalTypes[1])
                {
                    mCharacterInfos.Text = Strings.Character.oneelementaltype.ToString(Strings.Character.elementaltypes[(int)Globals.Me.ElementalTypes[0]]);
                }
                else
                {
                    if (Globals.Me.ElementalTypes[0] == ElementalType.None)
                    {
                        mCharacterInfos.Text = Strings.Character.oneelementaltype.ToString(Strings.Character.elementaltypes[(int)Globals.Me.ElementalTypes[1]]);
                    }
                    else if (Globals.Me.ElementalTypes[1] == ElementalType.None)
                    {
                        mCharacterInfos.Text = Strings.Character.oneelementaltype.ToString(Strings.Character.elementaltypes[(int)Globals.Me.ElementalTypes[0]]);
                    }
                    else
                    {
                        mCharacterInfos.Text = Strings.Character.twoelementaltype.ToString(
                            Strings.Character.elementaltypes[(int)Globals.Me.ElementalTypes[0]], Strings.Character.elementaltypes[(int)Globals.Me.ElementalTypes[1]]);
                    }
                }
            }

            //Load Portrait
            //UNCOMMENT THIS LINE IF YOU'D RATHER HAVE A FACE HERE GameTexture faceTex = Globals.ContentManager.GetTexture(GameContentManager.TextureType.Face, Globals.Me.Face);
            var entityTex = Globals.ContentManager.GetTexture(
                GameContentManager.TextureType.Entity, Globals.Me.MySprite
            );

            /* UNCOMMENT THIS BLOCK IF YOU"D RATHER HAVE A FACE HERE if (Globals.Me.Face != "" && Globals.Me.Face != _currentSprite && faceTex != null)
             {
                 _characterPortrait.Texture = faceTex;
                 _characterPortrait.SetTextureRect(0, 0, faceTex.GetWidth(), faceTex.GetHeight());
                 _characterPortrait.SizeToContents();
                 Align.Center(_characterPortrait);
                 _characterPortrait.IsHidden = false;
                 for (int i = 0; i < Options.EquipmentSlots.Count; i++)
                 {
                     _paperdollPanels[i].Hide();
                 }
             }
             else */
            if (Globals.Me.MySprite != "" && Globals.Me.MySprite != mCurrentSprite && entityTex != null)
            {
                for (var z = 0; z < Options.PaperdollOrder[1].Count; z++)
                {
                    var paperdoll = "";
                    if (Options.EquipmentSlots.IndexOf(Options.PaperdollOrder[1][z]) > -1)
                    {
                        var equipment = Globals.Me.MyEquipment;
                        if (equipment[Options.EquipmentSlots.IndexOf(Options.PaperdollOrder[1][z])] > -1 &&
                            equipment[Options.EquipmentSlots.IndexOf(Options.PaperdollOrder[1][z])] <
                            Options.MaxInvItems)
                        {
                            var itemNum = Globals.Me
                                .Inventory[equipment[Options.EquipmentSlots.IndexOf(Options.PaperdollOrder[1][z])]]
                                .ItemId;

                            if (ItemBase.Get(itemNum) != null)
                            {
                                var itemdata = ItemBase.Get(itemNum);
                                if (Globals.Me.Gender == 0)
                                {
                                    paperdoll = itemdata.MalePaperdoll;
                                }
                                else
                                {
                                    paperdoll = itemdata.FemalePaperdoll;
                                }
                            }
                        }
                    }
                    else if (Options.PaperdollOrder[1][z] == "Player")
                    {
                        PaperdollPanels[z].Show();
                        PaperdollPanels[z].Texture = entityTex;
                        PaperdollPanels[z].SetTextureRect(0, 0, entityTex.GetWidth() / Options.Instance.Sprites.NormalFrames, entityTex.GetHeight() / Options.Instance.Sprites.Directions);
                        PaperdollPanels[z].SizeToContents();
                        PaperdollPanels[z].RenderColor = Globals.Me.Color;
                        Align.Center(PaperdollPanels[z]);
                    }

                    if (string.IsNullOrWhiteSpace(paperdoll) && !string.IsNullOrWhiteSpace(PaperdollTextures[z]) && Options.PaperdollOrder[1][z] != "Player")
                    {
                        PaperdollPanels[z].Texture = null;
                        PaperdollPanels[z].Hide();
                        PaperdollTextures[z] = "";
                    }
                    else if (paperdoll != "" && paperdoll != PaperdollTextures[z])
                    {
                        var paperdollTex = Globals.ContentManager.GetTexture(
                            GameContentManager.TextureType.Paperdoll, paperdoll
                        );

                        PaperdollPanels[z].Texture = paperdollTex;
                        if (paperdollTex != null)
                        {
                            PaperdollPanels[z]
                                .SetTextureRect(
                                    0, 0, PaperdollPanels[z].Texture.GetWidth() / Options.Instance.Sprites.NormalFrames,
                                    PaperdollPanels[z].Texture.GetHeight() / Options.Instance.Sprites.Directions
                                );

                            PaperdollPanels[z]
                                .SetSize(
                                    PaperdollPanels[z].Texture.GetWidth() / Options.Instance.Sprites.NormalFrames,
                                    PaperdollPanels[z].Texture.GetHeight() / Options.Instance.Sprites.Directions
                                );

                            PaperdollPanels[z]
                                .SetPosition(
                                    mCharacterContainer.Width / 2 - PaperdollPanels[z].Width / 2,
                                    mCharacterContainer.Height / 2 - PaperdollPanels[z].Height / 2
                                );
                        }

                        PaperdollPanels[z].Show();
                        PaperdollTextures[z] = paperdoll;
                    }
                }
            }
            else if (Globals.Me.MySprite != mCurrentSprite && Globals.Me.Face != mCurrentSprite)
            {
                mCharacterPortrait.IsHidden = true;
                for (var i = 0; i < Options.EquipmentSlots.Count; i++)
                {
                    PaperdollPanels[i].Hide();
                }
            }
            string textStats = Strings.Character.stats;
            if (Globals.Me.StatPoints > 0)
            {
                textStats += " (" + Globals.Me.StatPoints + " " + Strings.Character.pointstouse + ")";
            }
            mStatsLabel.SetText(textStats);
            mAttackLabel.SetText(
                Strings.Character.stat0.ToString(Strings.Combat.stat0, Globals.Me.Stat[(int) Stats.Attack])
            );

            mDefenseLabel.SetText(
                Strings.Character.stat2.ToString(Strings.Combat.stat2, Globals.Me.Stat[(int) Stats.Defense])
            );

            mSpeedLabel.SetText(
                Strings.Character.stat4.ToString(Strings.Combat.stat4, Globals.Me.Stat[(int) Stats.Speed])
            );

            mAbilityPwrLabel.SetText(
                Strings.Character.stat1.ToString(Strings.Combat.stat1, Globals.Me.Stat[(int) Stats.AbilityPower])
            );

            mMagicRstLabel.SetText(
                Strings.Character.stat3.ToString(Strings.Combat.stat3, Globals.Me.Stat[(int) Stats.MagicResist])
            );
            mAttackSpeedLabel.SetText(Strings.Character.attackspeed.ToString(Math.Round(((float)Globals.Me.CalculateAttackTime()) / 1000f, 2)));
            mAddAbilityPwrBtn.IsHidden = Globals.Me.StatPoints == 0 ||
                                         Globals.Me.Stat[(int) Stats.AbilityPower] == Options.MaxStatValue;

            mAddAttackBtn.IsHidden =
                Globals.Me.StatPoints == 0 || Globals.Me.Stat[(int) Stats.Attack] == Options.MaxStatValue;

            mAddDefenseBtn.IsHidden = Globals.Me.StatPoints == 0 ||
                                      Globals.Me.Stat[(int) Stats.Defense] == Options.MaxStatValue;

            mAddMagicResistBtn.IsHidden = Globals.Me.StatPoints == 0 ||
                                          Globals.Me.Stat[(int) Stats.MagicResist] == Options.MaxStatValue;

            //mAddSpeedBtn.IsHidden =
            //    Globals.Me.StatPoints == 0 || Globals.Me.Stat[(int) Stats.Speed] == Options.MaxStatValue;

            for (var i = 0; i < Options.EquipmentSlots.Count; i++)
            {
                if (Globals.Me.MyEquipment[i] > -1 && Globals.Me.MyEquipment[i] < Options.MaxInvItems)
                {
                    if (Globals.Me.Inventory[Globals.Me.MyEquipment[i]].ItemId != Guid.Empty)
                    {
                        Items[i]
                            .Update(
                                Globals.Me.Inventory[Globals.Me.MyEquipment[i]].ItemId,
                                Globals.Me.Inventory[Globals.Me.MyEquipment[i]].StatBuffs,
                                Globals.Me.Inventory[Globals.Me.MyEquipment[i]].Effects
                            );
                    }
                    else
                    {
                        Items[i].Update(Guid.Empty, mEmptyStatBoost, mEmptyEffects);
                    }
                }
                else
                {
                    Items[i].Update(Guid.Empty, mEmptyStatBoost, mEmptyEffects);
                }
            }
        }

        public void Show()
        {
            mCharacterWindow.IsHidden = false;
        }

        public bool IsVisible()
        {
            return !mCharacterWindow.IsHidden;
        }

        public void Hide()
        {
            mCharacterWindow.IsHidden = true;
        }

    }

}
