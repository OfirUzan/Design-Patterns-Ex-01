using System;
using System.Device.Location;
using System.Xml;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class LocationServices
    {
        public GeoCoordinateWatcher GeoCoordinateWatcher { get; private set; }

        public string UserCurrentAdress { get; private set; }

        private double m_lastLatitude;
        private double m_lastLongitude;

        public LocationServices()
        {
            GeoCoordinateWatcher = new GeoCoordinateWatcher();
            GeoCoordinateWatcher.PositionChanged += GeoCoordinateWatcher_PositionChanged;
            GeoCoordinateWatcher.Start();
        }

        private void GeoCoordinateWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            m_lastLatitude = e.Position.Location.Latitude;
            m_lastLongitude = e.Position.Location.Longitude;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                string url = string.Format("https://api.opencagedata.com/geocode/v1/xml?q={0}%2C%20{1}&key=de6bc97eaa8a4c3a99198c1cfbf0fe9d&language=en&pretty=1", e.Position.Location.Latitude, e.Position.Location.Longitude);
                xmlDoc.Load(url);
                XmlNodeList xmlNodeList = xmlDoc.GetElementsByTagName("result");
                XmlNode xmlNode = xmlNodeList.Item(0);
                UserCurrentAdress = xmlNode.SelectSingleNode("formatted").InnerText;
            }
            catch
            {
                UserCurrentAdress = null;
            }

            GeoCoordinateWatcher.Stop();
        }

        // *** Following method will fail because we don't have location acess from facebook as supposed to *** //
        public bool IsFriendOnSearchRadius(User i_User, User i_Friend, double i_SearchRadius)
        {
            return true;

            // Returning always true just for testing purpuses!!!
            // Uncomment following lines for REAL implementation.
            /*double userLatitude = UserCurrentAdress != null ? m_lastLatitude : (double)i_User.Location.Location.Latitude;
            double userLongtitude = UserCurrentAdress != null ? m_lastLongitude : (double)i_User.Location.Location.Longitude;
            double friendLatitude = (double)i_Friend.Location.Location.Latitude;
            double friendLongtitude = (double)i_Friend.Location.Location.Longitude;
            return distanceBetween(userLatitude, userLongtitude, friendLatitude, friendLongtitude) <= i_SearchRadius;*/
        }

        private double convertToRadians(double i_Angle)
        {
            return (Math.PI / 180) * i_Angle;
        }

        // Following method will calculate distance between two points based on KM calculations.
        private double distanceBetween(double i_UserLatitude, double i_UserLongitude, double i_FriendLatitude, double i_FriendLongitude)
        {
            int earthRadiusInKM = 6371;
            double userLatRadians = convertToRadians(i_UserLatitude);
            double userLongRadians = convertToRadians(i_UserLongitude);
            double friendLatRadians = convertToRadians(i_FriendLatitude);
            double friendLonggRadians = convertToRadians(i_FriendLongitude);
            double u = Math.Sin((friendLatRadians - userLatRadians) / 2);
            double v = Math.Sin((friendLonggRadians - userLongRadians) / 2);

            return 2.0 * earthRadiusInKM * Math.Asin(Math.Sqrt((u * u) + (Math.Cos(userLatRadians) * Math.Cos(friendLatRadians) * v * v)));
        }
    }
}