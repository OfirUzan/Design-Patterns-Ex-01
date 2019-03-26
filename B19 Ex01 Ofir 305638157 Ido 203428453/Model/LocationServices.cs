using System;
using System.Device.Location;
using System.Xml;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class LocationServices
    {
        #region Class Members / Properties
        private const string    k_ApiLink = "https://api.opencagedata.com/geocode/v1/xml?q={0}%2C%20{1}&key=de6bc97eaa8a4c3a99198c1cfbf0fe9d&language=en&pretty=1";
        private const string    k_TagName = "result";
        private const string    k_SingleNode = "formatted";
        private const int       k_EarthRadiousInKM = 6371;
        private const int       k_Semicircle = 180;
        private double          m_LastLatitude;
        private double          m_LastLongitude;

        public GeoCoordinateWatcher GeoCodorinateWatcher { get; private set; }

        public string UserCurrentAdress { get; private set; }
        #endregion

        #region Class Methods
        private void GeoCoordinateWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            m_LastLatitude = e.Position.Location.Latitude;
            m_LastLongitude = e.Position.Location.Longitude;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                string url = string.Format(k_ApiLink, e.Position.Location.Latitude, e.Position.Location.Longitude);
                xmlDoc.Load(url);
                XmlNodeList xmlNodeList = xmlDoc.GetElementsByTagName(k_TagName);
                XmlNode xmlNode = xmlNodeList.Item(0);
                UserCurrentAdress = xmlNode.SelectSingleNode(k_SingleNode).InnerText;
            }
            catch
            {
                UserCurrentAdress = null;
            }

            GeoCodorinateWatcher.Stop();
        }

        private double convertToRadians(double i_Angle)
        {
            return Math.PI / k_Semicircle * i_Angle;
        }

        public LocationServices()
        {
            GeoCodorinateWatcher = new GeoCoordinateWatcher();
            GeoCodorinateWatcher.PositionChanged += GeoCoordinateWatcher_PositionChanged;
            GeoCodorinateWatcher.Start();
        }

        // Following method will calculate distance between two points based on KM calculations.
        private double distanceBetween(double i_UserLatitude, double i_UserLongitude, double i_FriendLatitude, double i_FriendLongitude)
        {
            double userLatRadians = convertToRadians(i_UserLatitude);
            double userLongRadians = convertToRadians(i_UserLongitude);
            double friendLatRadians = convertToRadians(i_FriendLatitude);
            double friendLonggRadians = convertToRadians(i_FriendLongitude);
            double u = Math.Sin((friendLatRadians - userLatRadians) / 2);
            double v = Math.Sin((friendLonggRadians - userLongRadians) / 2);

            return 2.0 * k_EarthRadiousInKM * Math.Asin(Math.Sqrt((u * u) + (Math.Cos(userLatRadians) * Math.Cos(friendLatRadians) * v * v)));
        }

        // *** Following method will fail because we don't have location acess from facebook as supposed to *** //
        public bool IsFriendOnSearchRadius(User i_User, User i_Friend, double i_SearchRadius)
        {
            const bool v_UnrealResult = true;
            return v_UnrealResult;

            // Returning always true just for testing purpuses!!!
            // Uncomment following lines for REAL implementation.
            /*double userLatitude = UserCurrentAdress != null ? m_lastLatitude : (double)i_User.Location.Location.Latitude;
            double userLongtitude = UserCurrentAdress != null ? m_lastLongitude : (double)i_User.Location.Location.Longitude;
            double friendLatitude = (double)i_Friend.Location.Location.Latitude;
            double friendLongtitude = (double)i_Friend.Location.Location.Longitude;
            return distanceBetween(userLatitude, userLongtitude, friendLatitude, friendLongtitude) <= i_SearchRadius;*/
        }
        #endregion
    }
}