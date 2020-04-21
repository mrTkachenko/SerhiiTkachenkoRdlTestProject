using System.Configuration;

namespace SerhiiTkachenkoTestRdl.Helpers
{
    public static class ConfigHelper
    {
        public static string GetConfigParameterByKey(string keyName)
        {
            return ConfigurationManager.AppSettings[keyName];
        }
    }
}
