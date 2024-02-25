using Intersect.GameObjects.Maps.MapRegion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intersect.Editor.Forms.Editors.MapRegions
{
    public class MapRegionCommandControl : UserControl
    {
        public bool Cancelled;
        public string mBackupConditionData;

        public MapRegionCommandControl()
        {

        }

        public MapRegionCommandControl(string data)
        {
            mBackupConditionData = data;
        }

    }
}
