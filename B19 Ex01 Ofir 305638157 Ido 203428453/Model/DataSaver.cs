using System.IO;

namespace Model
{
    class DataSaver
    {
        private static readonly string r_filePath = Directory.GetCurrentDirectory() + "\\AcessToken.txt";
        public string GetFacebookAcessToken()
        {
            return readFromBinaryFile(r_filePath);
        }

        public void SaveFacebookAcessToken(string i_AcessToken)
        {
            writeToBinaryFile(r_filePath, i_AcessToken);
        }

        private void writeToBinaryFile(string i_FilePath, string i_FileContents)
        {
            using (Stream stream = File.Open(i_FilePath, FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, i_FileContents);
            }
        }

        private string readFromBinaryFile(string i_FilePath)
        {
            string fileContents;

            if (!File.Exists(i_FilePath))
            {
                fileContents = null;
            }
            else
            {
                using (Stream stream = File.Open(i_FilePath, FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    fileContents = (string)binaryFormatter.Deserialize(stream);
                }
            }

            return fileContents;
        }

        internal void DeleteFacebookAcessToken()
        {
            File.Delete(r_filePath);
        }
    }
}
