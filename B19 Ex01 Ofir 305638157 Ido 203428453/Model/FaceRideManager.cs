using System;
using FacebookWrapper.ObjectModel;
using System.Device.Location;
using System.Threading.Tasks;

namespace Model
{
    public delegate void LocationChangedDelegate();
    public class FaceRideManager
    {
        #region Class Members / Properties

        public User ChosenFriend { get; set; }

        public FacebookObjectCollection<User> PossibleRideFriends { get; set; }

        public GeoCoordinateWatcher GeoCoordinateWatcher
        {
            get
            {
                return LocationServices.GeoCoordinateWatcher;
            }
        }

        #endregion

        #region Class Methods

        public FaceRideManager()
        {
            LocationServices.GeoCoordinateWatcher.PositionChanged += GeoCoordinateWatcher_PositionChanged;
        }

        private void GeoCoordinateWatcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            throw new NotImplementedException();
        }

        //This method receives the user's information, radius search and desired gender for the ride.
        //The method creates and returns a collection of potential FaceRide partners.
        public FacebookObjectCollection<User> GetPotentialRideFriends(User i_User, string i_SearchRadius, bool i_MaleFriends, bool i_FemaleFriends)
        {
            double radius = double.Parse(i_SearchRadius);
            PossibleRideFriends = new FacebookObjectCollection<User>();

            foreach (User friend in i_User.Friends)
            {
                if((friend.Gender == User.eGender.male && i_MaleFriends || friend.Gender == User.eGender.female && i_FemaleFriends)
                && isFriendOnSearchRadius(i_User, friend, radius))
                {
                    PossibleRideFriends.Add(friend);
                }
            }

            return PossibleRideFriends;
        }

        // *** Following method will fail because we don't have location acess from facebook as supposed to *** //
        private bool isFriendOnSearchRadius(User i_User, User i_Friend, double i_SearchRadius)
        {
            //Returning always true just for testing purpuses!!!
            return true;

            //Change to following implementation for REAL implementation.
            /*double userLatitude = (double)i_User.Location.Location.Latitude;
            double userLongtitude = (double)i_User.Location.Location.Longitude;
            double friendLatitude = (double)i_Friend.Location.Location.Latitude;
            double friendLongtitude = (double)i_Friend.Location.Location.Longitude;

            return distanceBetween(userLatitude, userLongtitude, friendLatitude, friendLongtitude) <= i_SearchRadius;*/
        }

        private double convertToRadians(double i_Angle)
        {
            return (Math.PI / 180) * i_Angle;
        }

        //Following method will calculate distance between two points based on KM calculations.
        public double distanceBetween(double i_UserLatitude, double i_UserLongitude, double i_FriendLatitude, double i_FriendLongitude)
        {
            //The radius of the earth in Km.
            int earthKmRadius = 6371;
            double userLatRadians = convertToRadians(i_UserLatitude);
            double userLongRadians = convertToRadians(i_UserLongitude);
            double friendLatRadians = convertToRadians(i_FriendLatitude);
            double friendLonggRadians = convertToRadians(i_FriendLongitude);
            double u = Math.Sin((friendLatRadians - userLatRadians) / 2);
            double v = Math.Sin((friendLonggRadians - userLongRadians) / 2);

            return 2.0 * earthKmRadius * Math.Asin(Math.Sqrt(u * u + Math.Cos(userLatRadians) * Math.Cos(friendLatRadians) * v * v));
        }

        public string GetUserCurrentAdress()
        {
            return LocationServices.UserCurrentAdress;
        }

        #endregion
    }
}