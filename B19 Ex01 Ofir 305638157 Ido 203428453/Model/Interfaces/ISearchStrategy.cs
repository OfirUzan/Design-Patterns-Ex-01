using FacebookWrapper.ObjectModel;

namespace Model.Interfaces
{
    public interface ISearchStrategy
    {
        FacebookObjectCollection<User> GetPotentialRideFriends();
    }
}