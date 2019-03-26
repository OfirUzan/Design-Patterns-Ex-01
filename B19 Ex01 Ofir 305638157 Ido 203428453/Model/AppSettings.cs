using System.IO;
using System.Xml.Serialization;

namespace Model
{
    public class AppSettings
    {
        #region Class Members / Properties
        private static readonly string sr_filePath = Directory.GetCurrentDirectory() + "\\AcessToken.txt";
        private static readonly object sr_ObjectCreationLockContext = new object();
        private static AppSettings     s_AppSettings = null;
        public string LastAcessToken { get; set; } = null;
        #endregion

        #region Class Methods
        public static AppSettings GetOrCreateAppSettingsFromXmlFile()
        {
            if (s_AppSettings == null)
            {
                lock (sr_ObjectCreationLockContext)
                {
                    if (s_AppSettings == null)
                    {
                        s_AppSettings = new AppSettings();
                    }
                }
            }
            
            if (File.Exists(sr_filePath))
            {
                using (Stream stream = File.Open(sr_filePath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
                    s_AppSettings = xmlSerializer.Deserialize(stream) as AppSettings;
                }
            }

            return s_AppSettings;
        }

        public void SaveAppSettingsToXmlFile()
        {
            using (Stream stream = new FileStream(sr_filePath, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                xmlSerializer.Serialize(stream, this);
            }
        }

        public void DeleteAppSettingsXmlFile()
        {
            if (File.Exists(sr_filePath))
            {
                File.Delete(sr_filePath);
            }
        }
        #endregion
    }
}
