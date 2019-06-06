using FacebookWrapper.ObjectModel;
using Model.Interfaces;

namespace Model
{
    public delegate void LocationChangedDelegate();

    internal class FaceRideManager
    {
        #region Class Members / Properties

        public User ChosenFriend { get; set; }

        public FacebookObjectCollection<User> PossibleRideFriends { get; set; }

        public ISearchStrategy SearchStrategy { get; set; }

        private LocationServices m_LocationServices = new LocationServices();
        #endregion

        #region Class Methods
        // The method creates and returns a collection of potential FaceRide partners.
        public FacebookObjectCollection<User> GetPotentialRideFriends()
        {
            PossibleRideFriends = SearchStrategy.GetPotentialRideFriends();
            return PossibleRideFriends;
        }

        public string GetUserCurrentAdress()
        {
            return m_LocationServices.UserCurrentAdress;
        }
        #endregion
    }
}