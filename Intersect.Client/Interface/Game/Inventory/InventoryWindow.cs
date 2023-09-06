using System.Collections.Generic;

using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.GenericClasses;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.General;
using Intersect.Client.Items;
using Intersect.Client.Localization;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.Localization;

namespace Intersect.Client.Interface.Game.Inventory
{

    public class InventoryWindow
    {

        //Item List
        public List<InventoryItem> Items = new List<InventoryItem>();

        //Initialized Items?
        private bool mInitializedItems = false;

        //Controls
        private WindowControl mInventoryWindow;

        private ScrollControl mItemContainer;

        private List<Label> mValues = new List<Label>();

        private Dictionary<InventoryTab, Button> mTabButtons = new Dictionary<InventoryTab, Button>();

        public InventoryTab CurrentTab = InventoryTab.All;

        private Label mCurrencyLabel;

        //Init
        public InventoryWindow(Canvas gameCanvas)
        {
            mInventoryWindow = new WindowControl(gameCanvas, "", false, "InventoryWindow");
            mInventoryWindow.DisableResizing();

            mCurrencyLabel = new Label(mInventoryWindow.mTitleBar, "CurrencyLabel");
            // Generate tab butons.
            for (var btn = 0; btn < (int)InventoryTab.Count; btn++)
            {
                mTabButtons.Add((InventoryTab)btn, new Button(mInventoryWindow, $"{(InventoryTab)btn}TabButton"));
                LocalizedString name;
                mTabButtons[(InventoryTab)btn].SetToolTipText(Strings.Inventory.InventoryTabTooltips.TryGetValue(btn, out name) ? name : Strings.General.none);
                mTabButtons[(InventoryTab)btn].Clicked += TabButtonClicked;
                // We'll be using the user data to determine which tab we've clicked later.
                mTabButtons[(InventoryTab)btn].UserData = (InventoryTab)btn;
            }

            // Disable this to start, since this is the default tab we open the client on.
            mTabButtons[InventoryTab.All].Disable();


            mItemContainer = new ScrollControl(mInventoryWindow, "ItemsContainer");
            mItemContainer.EnableScroll(false, true);
            mInventoryWindow.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());
        }

        /// <summary>
        /// Enables all the inventory tab buttons.
        /// </summary>
        private void EnableInventoryTabs()
        {
            for (var btn = 0; btn < (int)InventoryTab.Count; btn++)
            {
                mTabButtons[(InventoryTab)btn].Enable();
            }

        }

        /// <summary>
        /// Handles the click event of a inventory tab button.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="arguments">The arguments passed by the event.</param>
        private void TabButtonClicked(Base sender, ClickedEventArgs arguments)
        {
            // Enable all buttons again!
            EnableInventoryTabs();

            // Disable the clicked button to fake our tab being selected and set our selected inventory tab.
            sender.Disable();
            var tab = (InventoryTab)sender.UserData;
            CurrentTab = tab;
            mItemContainer.ScrollToTop();
            // Change the default channel we're trying to inventory in based on the tab we've just selected.
            //SetChannelToTab(tab);
        }

        //Location
        //Location
        public int X => mInventoryWindow.X;

        public int Y => mInventoryWindow.Y;

        //Methods
        public void Update()
        {
            if (!mInitializedItems)
            {
                mInitializedItems = true;
                InitItemContainer();
            }

            if (mInventoryWindow.IsHidden)
            {
                return;
            }
            ProcessInventorySort();
            mInventoryWindow.IsClosable = Globals.CanCloseInventory;
            var noCurrency = true;
            for (var i = 0; i < Options.MaxInvItems; i++)
            {
                if (Globals.Me.Inventory[i].ItemId == Options.Equipment.CurrencyItemId)
                {
                    mCurrencyLabel.Text = Globals.Me.Inventory[i].Quantity.ToString();
                    noCurrency = false;
                }
                var invSlot = Items[i].SortedSlot;
                var item = invSlot < 0 ? null : ItemBase.Get(Globals.Me.Inventory[invSlot].ItemId);
                if (item != null)
                {
                    Items[i].Pnl.IsHidden = false;
                    if (item.IsStackable)
                    {
                        mValues[i].IsHidden = Globals.Me.Inventory[invSlot].Quantity <= 1;
                        mValues[i].Text = Strings.FormatQuantityAbbreviated(Globals.Me.Inventory[invSlot].Quantity);
                    }
                    else
                    {
                        mValues[i].IsHidden = true;
                    }

                    if (Items[i].IsDragging)
                    {
                        Items[i].Pnl.IsHidden = true;
                        mValues[i].IsHidden = true;
                    }

                    Items[i].Update();
                    Items[i].UpdateRarity(item.Rarity);
                }
                else
                {
                    Items[i].UpdateRarity(-1);
                    Items[i].Pnl.IsHidden = true;
                    mValues[i].IsHidden = true;
                }
            }
            if (noCurrency)
            {
                mCurrencyLabel.Text = "0";
            }
        }

        private void InitItemContainer()
        {
            for (var i = 0; i < Options.MaxInvItems; i++)
            {
                Items.Add(new InventoryItem(this, i));
                Items[i].Container = new ImagePanel(mItemContainer, "InventoryItem");
                Items[i].Setup();

                mValues.Add(new Label(Items[i].Container, "InventoryItemValue"));
                mValues[i].Text = "";

                Items[i].Container.LoadJsonUi(GameContentManager.UI.InGame, Graphics.Renderer.GetResolutionString());

                if (Items[i].EquipPanel.Texture == null)
                {
                    Items[i].EquipPanel.Texture = Graphics.Renderer.GetWhiteTexture();
                }

                var xPadding = Items[i].Container.Margin.Left + Items[i].Container.Margin.Right;
                var yPadding = Items[i].Container.Margin.Top + Items[i].Container.Margin.Bottom;
                Items[i]
                    .Container.SetPosition(
                        i %
                        (mItemContainer.Width / (Items[i].Container.Width + xPadding)) *
                        (Items[i].Container.Width + xPadding) +
                        xPadding,
                        i /
                        (mItemContainer.Width / (Items[i].Container.Width + xPadding)) *
                        (Items[i].Container.Height + yPadding) +
                        yPadding
                    );
            }
        }

        public void Show()
        {
            mInventoryWindow.IsHidden = false;
        }

        public bool IsVisible()
        {
            return !mInventoryWindow.IsHidden;
        }

        public bool Hide()
        {
            if (!Globals.CanCloseInventory)
            {
                return false;
            }

            mInventoryWindow.IsHidden = true;
            return true;
        }

        public FloatRect RenderBounds()
        {
            var rect = new FloatRect()
            {
                X = mInventoryWindow.LocalPosToCanvas(new Point(0, 0)).X -
                    (Items[0].Container.Padding.Left + Items[0].Container.Padding.Right) / 2,
                Y = mInventoryWindow.LocalPosToCanvas(new Point(0, 0)).Y -
                    (Items[0].Container.Padding.Top + Items[0].Container.Padding.Bottom) / 2,
                Width = mInventoryWindow.Width + Items[0].Container.Padding.Left + Items[0].Container.Padding.Right,
                Height = mInventoryWindow.Height + Items[0].Container.Padding.Top + Items[0].Container.Padding.Bottom
            };

            return rect;
        }


        // Sort all the player's items and set the real slot of the currency
        public void ProcessInventorySort()
        {
            var i = 0;
            var sortedCount = 0;
            switch(CurrentTab)
            {
                case InventoryTab.All:
                    for (i = 0; i < Options.MaxInvItems; i++)
                    {
                        Items[i].SortedSlot = Items[i].InventorySlot;
                    }
                    break;
                case InventoryTab.Projectiles:
                    for (i = 0; i < Options.MaxInvItems; i++)
                    {
                        if (Globals.Me.Inventory[i].InventoryTab == InventoryTab.Projectiles)
                        {
                            Items[sortedCount].SortedSlot = i;
                            sortedCount++;
                        }
                    }
                    for (i = sortedCount; i < Options.MaxInvItems; i++)
                    {
                        Items[i].SortedSlot = -1;
                    }
                    break;
                case InventoryTab.Consumables:
                    for (i = 0; i < Options.MaxInvItems; i++)
                    {
                        if (Globals.Me.Inventory[i].InventoryTab == InventoryTab.Consumables)
                        {
                            Items[sortedCount].SortedSlot = i;
                            sortedCount++;
                        } 
                    }
                    for (i = sortedCount; i < Options.MaxInvItems; i++)
                    {
                        Items[i].SortedSlot = -1;
                    }
                    break;
                case InventoryTab.Equipments:
                    for (i = 0; i < Options.MaxInvItems; i++)
                    {
                        if (Globals.Me.Inventory[i].InventoryTab == InventoryTab.Equipments)
                        {
                            Items[sortedCount].SortedSlot = i;
                            sortedCount++;
                        }
                    }
                    for (i = sortedCount; i < Options.MaxInvItems; i++)
                    {
                        Items[i].SortedSlot = -1;
                    }
                    break;
                case InventoryTab.Others:
                    for (i = 0; i < Options.MaxInvItems; i++)
                    {
                        if (Globals.Me.Inventory[i].InventoryTab == InventoryTab.Others)
                        {
                            Items[sortedCount].SortedSlot = i;
                            sortedCount++;
                        }
                    }
                    for (i = sortedCount; i < Options.MaxInvItems; i++)
                    {
                        Items[i].SortedSlot = -1;
                    }
                    break;
            }
        }

    }

}
