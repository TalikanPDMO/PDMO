using Intersect.Configuration;

using Microsoft.Win32;

namespace Intersect.Editor
{

    public static class Preferences
    {

        public static void SavePreference(string key, string value)
        {
            var regkey = Registry.CurrentUser.OpenSubKey("Software", true);

            regkey.CreateSubKey("PDMO");
            regkey = regkey.OpenSubKey("PDMO", true);
            var editorkey = "PDMOEditor";
            if (ClientConfiguration.Instance.Host == "localhost" || ClientConfiguration.Instance.Host == "127.0.0.1")
            {
                editorkey += "Local";
            }
            regkey.CreateSubKey(editorkey);
            regkey = regkey.OpenSubKey(editorkey, true);
            regkey.SetValue(key, value);
        }

        public static string LoadPreference(string key)
        {
            var regkey = Registry.CurrentUser.OpenSubKey("Software", false);
            regkey = regkey.OpenSubKey("PDMO", false);
            if (regkey == null)
            {
                return "";
            }

            var editorkey = "PDMOEditor";
            if (ClientConfiguration.Instance.Host == "localhost" || ClientConfiguration.Instance.Host == "127.0.0.1")
            {
                editorkey += "Local";
            }

            regkey = regkey.OpenSubKey(editorkey);
            if (regkey == null)
            {
                return "";
            }

            var value = (string) regkey.GetValue(key);
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            return value;
        }

    }

}
