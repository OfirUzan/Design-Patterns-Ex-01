using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace Model
{
    public class FacebookAuthenticator
    {
        public bool IsUserLoggedIn(out User i_User)
        {
            //Implement real method by saving the access token to pc.
            i_User = FacebookService.Connect("EAAGaTwZCX7mkBABYUROUeIUZCn3DxkhqDkP4ZBEfkGptrWSWkqhsrJfZCYMlbtRWz8FhtdcXZA2ByMqOVx7n7ktg8zHecBc170pw7En2Ohg1EgV7ErRrz1mEzDi0sykK8D6IDnVuAKQXjSsZCSkpTDQ4PjH61288pqyOoMSQZAGQQZDZD").LoggedInUser;
            return true;
        }

        public User LoginUser()
        {
            //Save acess token upon sucess!!
            User user = FacebookService.Connect("EAAGaTwZCX7mkBABYUROUeIUZCn3DxkhqDkP4ZBEfkGptrWSWkqhsrJfZCYMlbtRWz8FhtdcXZA2ByMqOVx7n7ktg8zHecBc170pw7En2Ohg1EgV7ErRrz1mEzDi0sykK8D6IDnVuAKQXjSsZCSkpTDQ4PjH61288pqyOoMSQZAGQQZDZD").LoggedInUser;

            if (user == null)
            {
                throw new System.Exception("Login failed.");
            }

            return user;
        }
    }
}
