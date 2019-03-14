using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class FaceRideManager
    {
        //This method receives the user's information, radius search and desired gender for the ride.
        //The method creates and returns a collection of potential FaceRide partners.
        public FacebookObjectCollection<User> GetPotentialRideFriends(User i_User, string i_SearchRadius, bool i_MaleFriends, bool i_FemaleFriends)
        {
            double radius = double.Parse(i_SearchRadius);
            FacebookObjectCollection<User> possibleRideFriends = new FacebookObjectCollection<User>();

            foreach (User friend in i_User.Friends)
            {
                if((friend.Gender == User.eGender.male && i_MaleFriends || friend.Gender == User.eGender.female && i_FemaleFriends)
                && isFriendOnSearchRadius(i_User, friend, radius))
                {
                    possibleRideFriends.Add(friend);
                }
            }

            return possibleRideFriends;
        }

        // *** Following method will fail because we don't have location acess from facebook as supposed to *** //
        private bool isFriendOnSearchRadius(User i_User, User i_Friend, double i_SearchRadius)
        {
            double userLatitude = (double)i_User.Location.Location.Latitude;
            double userLongtitude = (double)i_User.Location.Location.Longitude;
            double friendLatitude = (double)i_Friend.Location.Location.Latitude;
            double friendLongtitude = (double)i_Friend.Location.Location.Longitude;

            return distanceBetween(userLatitude, userLongtitude, friendLatitude, friendLongtitude) <= i_SearchRadius;
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
    }
}