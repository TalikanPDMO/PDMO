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

        private readonly RichLabel mServerStatusLabel;

        private readonly ImagePanel mVersionArea;

        private readonly Label mVersionLabel;

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
            mServerStatusLabel = new RichLabel(mServerStatusArea, "ServerStatusLabel");
            mServerStatusArea.LoadJsonUi(GameContentManager.UI.Menu, Graphics.Renderer.GetResolutionString());
            mServerStatusLabel.AddText(Strings.Server.StatusLabel, Color.White, Framework.Gwen.Alignments.Center);
            switch (MainMenu.ActiveNetworkStatus)
            {
                case Network.NetworkStatus.Offline:
                case Network.NetworkStatus.HandshakeFailure:
                case Network.NetworkStatus.VersionMismatch:
                case Network.NetworkStatus.Failed:
                case Network.NetworkStatus.Quitting:
                    mServerStatusLabel.AddText(MainMenu.ActiveNetworkStatus.ToLocalizedString(), Color.Red, Framework.Gwen.Alignments.CenterV);
                    break;
                case Network.NetworkStatus.Online:
                    mServerStatusLabel.AddText(MainMenu.ActiveNetworkStatus.ToLocalizedString(), Color.Green, Framework.Gwen.Alignments.CenterV);
                    break;
                case Network.NetworkStatus.ServerFull:
                    mServerStatusLabel.AddText(MainMenu.ActiveNetworkStatus.ToLocalizedString(), Color.Orange, Framework.Gwen.Alignments.CenterV);
                    break;
                default:
                    mServerStatusLabel.AddText(MainMenu.ActiveNetworkStatus.ToLocalizedString(), Color.White, Framework.Gwen.Alignments.CenterV);
                    break;
            }
            MainMenu.NetworkStatusChanged += HandleNetworkStatusChanged;

            mLinksArea = new ImagePanel(mMenuCanvas, "LinksArea");
            mWebsiteButton = new Button(mLinksArea, "WebsiteButton");
            mWebsiteButton.Clicked += WebsiteButton_Clicked;
            mDiscordButton = new Button(mLinksArea, "DiscordButton");
            mDiscordButton.Clicked += DiscordButton_Clicked;
            mLinksArea.LoadJsonUi(GameContentManager.UI.Menu, Graphics.Renderer.GetResolutionString());

            mVersionArea = new ImagePanel(mMenuCanvas, "VersionArea");
            mVersionLabel = new Label(mVersionArea, "VersionLabel");
            mVersionArea.LoadJsonUi(GameContentManager.UI.Menu, Graphics.Renderer.GetResolutionString());
            mVersionLabel.SetText(Strings.Server.Version.ToString(System.Windows.Forms.Application.ProductVersion));
        }

        ~MenuGuiBase()
        {
            // ReSharper disable once DelegateSubtraction
            MainMenu.NetworkStatusChanged -= HandleNetworkStatusChanged;
        }

        private void HandleNetworkStatusChanged()
        {
            mServerStatusLabel.ClearText();
            mServerStatusLabel.AddText(Strings.Server.StatusLabel, Color.White, Framework.Gwen.Alignments.Center);
            switch (MainMenu.ActiveNetworkStatus)
            {
                case Network.NetworkStatus.Offline:
                case Network.NetworkStatus.HandshakeFailure:
                case Network.NetworkStatus.VersionMismatch:
                case Network.NetworkStatus.Failed:
                case Network.NetworkStatus.Quitting:
                    mServerStatusLabel.AddText(MainMenu.ActiveNetworkStatus.ToLocalizedString(), Color.Red, Framework.Gwen.Alignments.CenterV);
                    break;
                case Network.NetworkStatus.Online:
                    mServerStatusLabel.AddText(MainMenu.ActiveNetworkStatus.ToLocalizedString(), Color.Green, Framework.Gwen.Alignments.CenterV);
                    break;
                case Network.NetworkStatus.ServerFull:
                    mServerStatusLabel.AddText(MainMenu.ActiveNetworkStatus.ToLocalizedString(), Color.Orange, Framework.Gwen.Alignments.CenterV);
                    break;
                default:
                    mServerStatusLabel.AddText(MainMenu.ActiveNetworkStatus.ToLocalizedString(), Color.White, Framework.Gwen.Alignments.CenterV);
                    break;
            }
        }

        private void WebsiteButton_Clicked(Base sender, ClickedEventArgs arguments)
        {
            System.Diagnostics.Process.Start("https://pdmo.eu/");
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
