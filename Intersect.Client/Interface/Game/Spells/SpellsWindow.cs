using System;
using System.Collections.Generic;

using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.GenericClasses;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.General;
using Intersect.Client.Localization;
using Intersect.GameObjects;

namespace Intersect.Client.Interface.Game.Spells
{

    public class SpellsWindow
    {

        //Spell List
        public List<SpellItem> Items = new List<SpellItem>();

        //Initialized
        private bool mInitializedSpells;

        

        //Item/Spell Rendering
        private ImagePanel mCommonsContainer;
        //Item/Spell Rendering
        private ImagePanel mUltimatesContainer;

        //Controls
        private WindowControl mSpellWindow;

        //Location
        public int X;

        public int Y;

        //Init
        public SpellsWindow(Canvas gameCanvas)
        {
            mSpellWindow = new WindowControl(gameCanvas, "", false, "SpellsWindow");
            mSpellWindow.DisableResizing();
            mCommonsContainer = new ImagePanel(mSpellWindow, "CommonSpellsContainer");

            mUltimatesContainer = new ImagePanel(mSpellWindow, "UltimateSpellsContainer");
            mSpellWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
        }

        //Methods
        public void Update()
        {
            var cls = ClassBase.Get(Globals.Me.Class);
            if (!mInitializedSpells)
            {
                InitItemContainers(cls);
                mInitializedSpells = true;
            }

            if (mSpellWindow.IsHidden == true)
            {
                return;
            }

            X = mSpellWindow.X;
            Y = mSpellWindow.Y;
            for (var i = 0; i < Options.MaxPlayerSkills; i++)
            {
                Items[i].Update();
            }
                /*if (i < cls.Spells.Count)
                {
                    //Items[i].Pnl.IsHidden = false;
                    //Items[i].SpellSlot = GetSpellSlotIndex(cls.Spells[i].Id, false);
                    Items[i].Update();
                    /*if (Items[i].IsDragging)
                    {
                        Items[i].Pnl.IsHidden = true;
                    }
                }     
                if (Globals.Me.Spells[i].SpellId != Guid.Empty)
                {
                    Items[i].Pnl.IsHidden = false;
                    Items[i].Update();
                    if (Items[i].IsDragging)
                    {
                        Items[i].Pnl.IsHidden = true;
                    }
                }
                else
                {
                    Items[i].Pnl.IsHidden = true;
                }
            }
            for (var i = Options.Instance.PlayerOpts.MaxCommonSpells; i < Options.MaxPlayerSkills; i++)
            {
                if (i < cls.Spells.Count)
                {
                    //Items[i].Pnl.IsHidden = false;
                    Items[i].SpellSlot = GetSpellSlotIndex(cls.Spells[i].Id, true);
                    Items[i].Update(cls);
                }    
            }*/
        }

        public int GetSpellSlotIndex(Guid spellId, bool isUltimate = false)
        {
            for (int i = 0; i<Globals.Me.Spells.Length; i++)
            {
                if (Globals.Me.Spells[i].SpellId == spellId && Globals.Me.Spells[i].Ultimate == isUltimate)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InitItemContainers(ClassBase cls)
        {
            var commonList = new List<ClassSpell>();
            var ultimateList = new List<ClassSpell>();
            foreach (var s in cls.Spells)
            {
                var sBase = SpellBase.Get(s.Id);
                if (sBase != null)
                {
                    if (sBase.Ultimate)
                    {
                        ultimateList.Add(s);
                    }
                    else
                    {
                        commonList.Add(s);
                    }
                }
            }
            for (var i = 0; i < Options.Instance.PlayerOpts.MaxCommonSpells; i++)
            {
                
                Items.Add(new SpellItem(this, i, i<commonList.Count ? commonList[i] : null));
                Items[i].Container = new ImagePanel(mCommonsContainer, "SpellItem");
                Items[i].Setup();

                Items[i].Container.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

                var xPadding = Items[i].Container.Margin.Left + Items[i].Container.Margin.Right;
                var yPadding = Items[i].Container.Margin.Top + Items[i].Container.Margin.Bottom;
                Items[i]
                    .Container.SetPosition(
                        i %
                        (mCommonsContainer.Width / (Items[i].Container.Width + xPadding)) *
                        (Items[i].Container.Width + xPadding) +
                        xPadding,
                        i /
                        (mCommonsContainer.Width / (Items[i].Container.Width + xPadding)) *
                        (Items[i].Container.Height + yPadding) +
                        yPadding
                    );
            }
            for (var u = 0; u < Options.Instance.PlayerOpts.MaxUltimateSpells; u++)
            {
                var i = u + Options.Instance.PlayerOpts.MaxCommonSpells;
                Items.Add(new SpellItem(this, i, u < ultimateList.Count ? ultimateList[u] : null));
                Items[i].Container = new ImagePanel(mUltimatesContainer, "SpellItem");
                Items[i].Setup();
                Items[i].Container.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
                var xPadding = Items[i].Container.Margin.Left + Items[i].Container.Margin.Right;
                var yPadding = Items[i].Container.Margin.Top + Items[i].Container.Margin.Bottom;
                var position = i - Options.Instance.PlayerOpts.MaxCommonSpells;
                Items[i]
                    .Container.SetPosition(
                        position %
                        (mUltimatesContainer.Width / (Items[i].Container.Width + xPadding)) *
                        (Items[i].Container.Width + xPadding) +
                        xPadding,
                        position /
                        (mUltimatesContainer.Width / (Items[i].Container.Width + xPadding)) *
                        (Items[i].Container.Height + yPadding) +
                        yPadding
                    );
            }
        }

        public void Show()
        {
            mSpellWindow.IsHidden = false;
        }

        public bool IsVisible()
        {
            return !mSpellWindow.IsHidden;
        }

        public void Hide()
        {
            mSpellWindow.IsHidden = true;
        }

        public FloatRect RenderBounds()
        {
            var rect = new FloatRect()
            {
                X = mSpellWindow.LocalPosToCanvas(new Point(0, 0)).X -
                    (Items[0].Container.Padding.Left + Items[0].Container.Padding.Right) / 2,
                Y = mSpellWindow.LocalPosToCanvas(new Point(0, 0)).Y -
                    (Items[0].Container.Padding.Top + Items[0].Container.Padding.Bottom) / 2,
                Width = mSpellWindow.Width + Items[0].Container.Padding.Left + Items[0].Container.Padding.Right,
                Height = mSpellWindow.Height + Items[0].Container.Padding.Top + Items[0].Container.Padding.Bottom
            };

            return rect;
        }

    }

}
