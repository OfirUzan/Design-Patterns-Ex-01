using FacebookWrapper.ObjectModel;
using Model.Interfaces;

namespace Model
{
    class RadiusSearchStrategy : ISearchStrategy
    {
        public User User { get; set; }

        public string SearchRadius { get; set; }

        public bool MaleFriends { get; set; }

        public bool FemaleFriends { get; set; }

        private LocationServices m_LocationServices = new LocationServices();

        public FacebookObjectCollection<User> GetPotentialRideFriends()
        {
            FacebookObjectCollection<User> possibleRideFriends;
            double radius = double.Parse(SearchRadius);

            possibleRideFriends = new FacebookObjectCollection<User>();

            foreach (User friend in User.Friends)
            {
                if (((friend.Gender == User.eGender.male && MaleFriends) || (friend.Gender == User.eGender.female && FemaleFriends)) && m_LocationServices.IsFriendOnSearchRadius(User, friend, radius))
                {
                    possibleRideFriends.Add(friend);
                }
            }

            return possibleRideFriends;
        }
    }
}
