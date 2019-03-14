﻿using System.IO;
using System.Xml.Serialization;

namespace Model
{
    public class AppSettings
    {
        private static readonly string r_filePath = Directory.GetCurrentDirectory() + "\\AcessToken.txt";
        private static readonly object r_ObjectCreationLockContext = new object();
        private static AppSettings s_appSettings = null;
        public string LastAcessToken { get; set; } = null;

        private AppSettings() { }

        public void SaveAppSettingsToXmlFile()
        {
            using (Stream stream = new FileStream(r_filePath, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                xmlSerializer.Serialize(stream, this);
            }
        }

        public static AppSettings GetOrCreateAppSettingsFromXmlFile()
        {
            lock (r_ObjectCreationLockContext)
            {
                if (s_appSettings == null)
                {
                    s_appSettings = new AppSettings();
                }
            }

            if (File.Exists(r_filePath))
            {
                using (Stream stream = File.Open(r_filePath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
                    s_appSettings = xmlSerializer.Deserialize(stream) as AppSettings;
                }
            }

            return s_appSettings;
        }

        public void DeleteAppSettings()
        {
            if (File.Exists(r_filePath))
            {
                File.Delete(r_filePath);
            }
        }
    }
}