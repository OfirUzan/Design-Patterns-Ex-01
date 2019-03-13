using System.IO;
using System.Xml.Serialization;

namespace Model
{
    public class AppSettings
    {
        private static readonly string r_filePath = Directory.GetCurrentDirectory() + "\\AcessToken.txt";
        public string LastAcessToken { get; set; } = null;

        private AppSettings() { }

        public void SaveSettingsToXmlFile()
        {
            using (Stream stream = new FileStream(r_filePath, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                xmlSerializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadAppSettingsFromXmlFile()
        {
            AppSettings appSettings = new AppSettings();

            if (File.Exists(r_filePath))
            {
                using (Stream stream = File.Open(r_filePath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = xmlSerializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettings;
        }

        public void DeleteAppSettings()
        {
            File.Delete(r_filePath);
        }
    }
}
