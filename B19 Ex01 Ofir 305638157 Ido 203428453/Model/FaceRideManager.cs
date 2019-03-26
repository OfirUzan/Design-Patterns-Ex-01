using FacebookWrapper.ObjectModel;

namespace Model
{
    public delegate void LocationChangedDelegate();

    public class FaceRideManager
    {
        #region Class Members / Properties
        private LocationServices m_LocationServices = new LocationServices();

        public User ChosenFriend { get; set; }

        public FacebookObjectCollection<User> PossibleRideFriends { get; set; }
        #endregion

        #region Class Methods
        // This method receives the user's information, radius search and desired gender for the ride.
        // The method creates and returns a collection of potential FaceRide partners.
        public FacebookObjectCollection<User> GetPotentialRideFriends(User i_User, string i_SearchRadius, bool i_MaleFriends, bool i_FemaleFriends)
        {
            double radius = double.Parse(i_SearchRadius);
            PossibleRideFriends = new FacebookObjectCollection<User>();

            foreach (User friend in i_User.Friends)
            {
                if (((friend.Gender == User.eGender.male && i_MaleFriends) || (friend.Gender == User.eGender.female && i_FemaleFriends)) && m_LocationServices.IsFriendOnSearchRadius(i_User, friend, radius))
                {
                    PossibleRideFriends.Add(friend);
                }
            }

            return PossibleRideFriends;
        }

        public string GetUserCurrentAdress()
        {
            return m_LocationServices.UserCurrentAdress;
        }
        #endregion
    }
}