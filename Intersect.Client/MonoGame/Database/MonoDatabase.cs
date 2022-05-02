using System;

using Intersect.Client.Framework.Database;
using Intersect.Configuration;

using Microsoft.Win32;

namespace Intersect.Client.MonoGame.Database
{

    public class MonoDatabase : GameDatabase
    {

        public override void SavePreference(string key, object value)
        {
            var regkey = Registry.CurrentUser?.OpenSubKey("Software", true);

            regkey?.CreateSubKey("PDMO");
            regkey = regkey?.OpenSubKey("PDMO", true);
            var clientkey = "PDMOClient";
            if (ClientConfiguration.Instance.Host == "localhost" || ClientConfiguration.Instance.Host == "127.0.0.1")
            {
                clientkey += "Local";
            }
            regkey?.CreateSubKey(clientkey);
            regkey = regkey?.OpenSubKey(clientkey, true);
            regkey?.SetValue(key, Convert.ToString(value));
        }

        public override string LoadPreference(string key)
        {
            var regkey = Registry.CurrentUser?.OpenSubKey("Software", false);

            regkey = regkey?.OpenSubKey("PDMO", false);
            var clientkey = "PDMOClient";
            if (ClientConfiguration.Instance.Host == "localhost" || ClientConfiguration.Instance.Host == "127.0.0.1")
            {
                clientkey += "Local";
            }
            regkey = regkey?.OpenSubKey(clientkey);
            return regkey?.GetValue(key) as string ?? "";
        }

        public override bool LoadConfig()
        {
            ClientConfiguration.LoadAndSave();

            return true;
        }

    }

}
