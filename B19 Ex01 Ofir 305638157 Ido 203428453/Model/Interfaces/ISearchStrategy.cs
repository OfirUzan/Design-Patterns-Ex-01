using FacebookWrapper.ObjectModel;

namespace Model.Interfaces
{
    interface ISearchStrategy
    {
        FacebookObjectCollection<User> GetPotentialRideFriends();
    }
}