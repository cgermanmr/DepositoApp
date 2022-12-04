using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public static class Configuracion
    {

        public static bool IsDbConfig()
        {
            var IsDbConfig = TryGetValueFromAppSettings("IsDbConfig", "false");
            
            return IsDbConfig == "true";

        }

        public static string TryGetValueFromAppSettings(string keyName, string defaultValue = null)
        {
            var value = ConfigurationManager.AppSettings[keyName];
            if (string.IsNullOrEmpty(value))
            {
                if (defaultValue != null)
                {
                    AddOrUpdateAppSettings(keyName, defaultValue);
                    return defaultValue;
                }

                throw new InvalidOperationException($"Falta key {keyName} en el archivo de configuración.");
            }
            return value;
        }

        public static void AddOrUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }

    }
}
