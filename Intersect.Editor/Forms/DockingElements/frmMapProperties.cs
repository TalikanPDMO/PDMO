using System.Collections.Generic;
using System.Windows.Forms;
using Intersect.Editor.General;
using Intersect.Editor.Localization;
using Intersect.Editor.Maps;
using Intersect.Enums;
using Intersect.GameObjects;
using Intersect.GameObjects.Maps;
using WeifenLuo.WinFormsUI.Docking;

namespace Intersect.Editor.Forms.DockingElements
{

    public partial class FrmMapProperties : DockContent
    {

        //Cross Thread Delegates
        public delegate void UpdateProperties();
        public MapBase mapStoredProperties; // Empty map for storing copied properties
        public UpdateProperties UpdatePropertiesDelegate;

        public FrmMapProperties()
        {
            InitializeComponent();
            UpdatePropertiesDelegate = Update;
            mapStoredProperties = null;
            this.Icon = Properties.Resources.Icon;
            btnPasteProperties.Enabled = mapStoredProperties != null;
        }

        public void Init(MapInstance map)
        {
            if (gridMapProperties.InvokeRequired)
            {
                gridMapProperties.Invoke((MethodInvoker) delegate { Init(map); });

                return;
            }

            gridMapProperties.SelectedObject = new MapProperties(map);
            InitLocalization();
        }

        private void InitLocalization()
        {
            Text = Strings.MapProperties.title;
            btnCopyProperties.Text = Strings.MapProperties.copyproperties;
            btnPasteProperties.Text = Strings.MapProperties.pasteproperties;
        }

        public void Update()
        {
            gridMapProperties.Refresh();
        }

        public GridItem Selection()
        {
            return gridMapProperties.SelectedGridItem;
        }

        private void btnCopyProperties_Click(object sender, System.EventArgs e)
        {
            if (mapStoredProperties == null)
            {
                mapStoredProperties = new MapBase();
            }
            MapInstance currentMap = Globals.CurrentMap;
            mapStoredProperties.Music = currentMap.Music;
            mapStoredProperties.Sound = currentMap.Sound;
            mapStoredProperties.Fog = currentMap.Fog;
            mapStoredProperties.FogTransparency = currentMap.FogTransparency;
            mapStoredProperties.FogXSpeed = currentMap.FogXSpeed;
            mapStoredProperties.ZoneType = currentMap.ZoneType;
            mapStoredProperties.Brightness = currentMap.Brightness;
            mapStoredProperties.IsIndoors = currentMap.IsIndoors;
            mapStoredProperties.PlayerLightColor = currentMap.PlayerLightColor;
            mapStoredProperties.PlayerLightExpand = currentMap.PlayerLightExpand;
            mapStoredProperties.PlayerLightIntensity = currentMap.PlayerLightIntensity; //tester
            mapStoredProperties.PlayerLightSize = currentMap.PlayerLightSize;
            mapStoredProperties.OverlayGraphic = currentMap.OverlayGraphic;
            mapStoredProperties.Panorama = currentMap.Panorama;
            mapStoredProperties.AHue = currentMap.AHue;
            mapStoredProperties.BHue = currentMap.BHue;
            mapStoredProperties.GHue = currentMap.GHue;
            mapStoredProperties.RHue = currentMap.RHue;
            mapStoredProperties.WeatherAnimation = AnimationBase.Get(currentMap.WeatherAnimationId);
            mapStoredProperties.WeatherIntensity = currentMap.WeatherIntensity;
            mapStoredProperties.WeatherXSpeed = currentMap.WeatherXSpeed;
            mapStoredProperties.WeatherYSpeed = currentMap.WeatherYSpeed;
            btnPasteProperties.Enabled = true;
        }

        private void btnPasteProperties_Click(object sender, System.EventArgs e)
        {
            if (btnPasteProperties.Enabled && mapStoredProperties != null)
            {
                Globals.MapEditorWindow.PrepUndoState();
                MapInstance currentMap = Globals.CurrentMap;
                currentMap.Music = mapStoredProperties.Music;
                currentMap.Sound = mapStoredProperties.Sound;
                currentMap.Fog = mapStoredProperties.Fog;
                currentMap.FogTransparency = mapStoredProperties.FogTransparency;
                currentMap.FogXSpeed = mapStoredProperties.FogXSpeed;
                currentMap.ZoneType = mapStoredProperties.ZoneType;
                currentMap.Brightness = mapStoredProperties.Brightness;
                currentMap.IsIndoors = mapStoredProperties.IsIndoors;
                currentMap.PlayerLightColor = mapStoredProperties.PlayerLightColor;
                currentMap.PlayerLightExpand = mapStoredProperties.PlayerLightExpand;
                currentMap.PlayerLightIntensity = mapStoredProperties.PlayerLightIntensity; //tester
                currentMap.PlayerLightSize = mapStoredProperties.PlayerLightSize;
                currentMap.OverlayGraphic = mapStoredProperties.OverlayGraphic;
                currentMap.Panorama = mapStoredProperties.Panorama;
                currentMap.AHue = mapStoredProperties.AHue;
                currentMap.BHue = mapStoredProperties.BHue;
                currentMap.GHue = mapStoredProperties.GHue;
                currentMap.RHue = mapStoredProperties.RHue;
                currentMap.WeatherAnimation = AnimationBase.Get(mapStoredProperties.WeatherAnimationId);
                currentMap.WeatherIntensity = mapStoredProperties.WeatherIntensity;
                currentMap.WeatherXSpeed = mapStoredProperties.WeatherXSpeed;
                currentMap.WeatherYSpeed = mapStoredProperties.WeatherYSpeed;
                gridMapProperties.Refresh();
                Globals.MapEditorWindow.AddUndoState();
            }
        }
    }

}
