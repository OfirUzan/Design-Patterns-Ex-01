using System.Device.Location;
using System.Xml;

namespace Model
{
    public static class LocationServices
    {
        public static GeoCoordinateWatcher GeoCoordinateWatcher { get; private set; }

        public static string UserCurrentAdress { get; private set; }

        static LocationServices()
        {
            GeoCoordinateWatcher = new GeoCoordinateWatcher();
            GeoCoordinateWatcher.PositionChanged += GeoCoordinateWatcher_PositionChanged;
            GeoCoordinateWatcher.Start();
        }

        private static void GeoCoordinateWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(@"https://maps.googleapis.com/maps/api/geocode/xml?latlng=" + e.Position.Location);
                XmlNodeList xmlNodeList = xmlDoc.GetElementsByTagName("result");
                XmlNode xmlNode = xmlNodeList.Item(0);
                UserCurrentAdress = xmlNode.SelectSingleNode("formatted_address").InnerText;
            }
            catch
            {
                UserCurrentAdress = null;
            }
        }
    }
}
