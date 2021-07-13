using System.Collections.Generic;

using Intersect.Client.Core;
using Intersect.Client.Framework.File_Management;
using Intersect.Client.Framework.Gwen.Control;
using Intersect.Client.Framework.Gwen.Control.EventArguments;
using Intersect.Client.Localization;
using Intersect.Client.Networking;

namespace Intersect.Client.Interface.Menu
{

    public class MenuGuiBase : IMutableInterface
    {

        private static MainMenu.NetworkStatusHandler sNetworkStatusChanged;

        private readonly Canvas mMenuCanvas;

        private readonly ImagePanel mServerStatusArea;

        private readonly Label mServerStatusLabel;

        private readonly ImagePanel mLinksArea;

        private readonly Button mWebsiteButton;

        private readonly Button mDiscordButton;

        public MainMenu MainMenu { get; }

        private bool mShouldReset;

        public MenuGuiBase(Canvas myCanvas)
        {
            mMenuCanvas = myCanvas;
            MainMenu = new MainMenu(mMenuCanvas);
            mServerStatusArea = new ImagePanel(mMenuCanvas, "ServerStatusArea");
            mServerStatusLabel = new Label(mServerStatusArea, "ServerStatusLabel")
            {
                Text = Strings.Server.StatusLabel.ToString(MainMenu.ActiveNetworkStatus.ToLocalizedString()),
            };

            mServerStatusArea.LoadJsonUi(GameContentManager.UI.Menu, Graphics.Renderer.GetResolutionString());
            MainMenu.NetworkStatusChanged += HandleNetworkStatusChanged;

            mLinksArea = new ImagePanel(mMenuCanvas, "LinksArea");
            mWebsiteButton = new Button(mLinksArea, "WebsiteButton");
            mWebsiteButton.Clicked += WebsiteButton_Clicked;
            mDiscordButton = new Button(mLinksArea, "DiscordButton");
            mDiscordButton.Clicked += DiscordButton_Clicked;
            mLinksArea.LoadJsonUi(GameContentManager.UI.Menu, Graphics.Renderer.GetResolutionString());
        }

        ~MenuGuiBase()
        {
            // ReSharper disable once DelegateSubtraction
            MainMenu.NetworkStatusChanged -= HandleNetworkStatusChanged;
        }

        private void HandleNetworkStatusChanged()
        {
            mServerStatusLabel.Text =
                Strings.Server.StatusLabel.ToString(MainMenu.ActiveNetworkStatus.ToLocalizedString());
        }

        private void WebsiteButton_Clicked(Base sender, ClickedEventArgs arguments)
        {
            System.Diagnostics.Process.Start("https://pdmo.fr/");
        }
        private void DiscordButton_Clicked(Base sender, ClickedEventArgs arguments)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/xYJQ82K");
        }

        public void Draw()
        {
            if (mShouldReset)
            {
                MainMenu.Reset();
                mShouldReset = false;
            }

            MainMenu.Update();
            mMenuCanvas.RenderCanvas();
        }

        public void Reset()
        {
            mShouldReset = true;
        }

        //Dispose
        public void Dispose()
        {
            mMenuCanvas?.Dispose();
        }

        /// <inheritdoc />
        public List<Base> Children => MainMenu.Children;

        /// <inheritdoc />
        public TElement Create<TElement>(params object[] parameters) where TElement : Base =>
            MainMenu.Create<TElement>(parameters);

        /// <inheritdoc />
        public TElement Find<TElement>(string name = null, bool recurse = false) where TElement : Base =>
            MainMenu.Find<TElement>(name, recurse);

        /// <inheritdoc />
        public IEnumerable<TElement> FindAll<TElement>(bool recurse = false) where TElement : Base =>
            MainMenu.FindAll<TElement>(recurse);

        /// <inheritdoc />
        public void Remove<TElement>(TElement element, bool dispose = false) where TElement : Base =>
            MainMenu.Remove(element, dispose);

    }

}
