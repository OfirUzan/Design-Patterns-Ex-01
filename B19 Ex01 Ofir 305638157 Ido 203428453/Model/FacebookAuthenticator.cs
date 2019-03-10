using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace Model
{
    public class FacebookAuthenticator
    {
        private DataSaver m_dataSaver;

        public FacebookAuthenticator()
        {
            m_dataSaver = new DataSaver();
        }

        public bool IsUserLoggedIn(out User o_User)
        {
            bool isLoggedIn;
            string acessToken = m_dataSaver.GetFacebookAcessToken();

            if(acessToken != null)
            {
                o_User = FacebookService.Connect(acessToken).LoggedInUser;

                //Check what happens when FacebookService.Login failes. is result null or loggedUser is null?
                if (o_User != null)
                {
                    isLoggedIn = true;
                }
                else
                {
                    isLoggedIn = true;
                }
            }
            else
            {
                o_User = null;
                isLoggedIn = false;
            }
            //i_User = FacebookService.Connect("EAAGaTwZCX7mkBABYUROUeIUZCn3DxkhqDkP4ZBEfkGptrWSWkqhsrJfZCYMlbtRWz8FhtdcXZA2ByMqOVx7n7ktg8zHecBc170pw7En2Ohg1EgV7ErRrz1mEzDi0sykK8D6IDnVuAKQXjSsZCSkpTDQ4PjH61288pqyOoMSQZAGQQZDZD").LoggedInUser;
            return isLoggedIn;
        }

        public User LoginUser()
        {
            LoginResult result = FacebookService.Login("451139335614057", "public_profile", "email", "publish_to_groups", "user_birthday", "user_age_range", "user_gender", "user_link", "user_tagged_places", "user_videos", "publish_to_groups", "groups_access_member_info", "user_friends", "user_events", "user_likes", "user_location", "user_photos", "user_posts", "user_hometown");

            //User user = FacebookService.Connect("EAAGaTwZCX7mkBABYUROUeIUZCn3DxkhqDkP4ZBEfkGptrWSWkqhsrJfZCYMlbtRWz8FhtdcXZA2ByMqOVx7n7ktg8zHecBc170pw7En2Ohg1EgV7ErRrz1mEzDi0sykK8D6IDnVuAKQXjSsZCSkpTDQ4PjH61288pqyOoMSQZAGQQZDZD").LoggedInUser;

            //Check what happens when FacebookService.Login failes. is result null or loggedUser is null?
            if (result.LoggedInUser != null)
            {
                m_dataSaver.SaveFacebookAcessToken(result.AccessToken);
            }

            else
            {
                throw new System.Exception("Login failed.");
            }

            return result.LoggedInUser;
        }

        public void LogoutUser()
        {
            m_dataSaver.DeleteFacebookAcessToken();
        }
    }
}
