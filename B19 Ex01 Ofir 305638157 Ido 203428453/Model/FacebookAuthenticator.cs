using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace Model
{
    public class FacebookAuthenticator
    {
        private AppSettings m_AppSettings;

        public bool RememberUser { get; set; } = false;

        public FacebookAuthenticator()
        {
            m_AppSettings = AppSettings.LoadAppSettingsFromXmlFile();
        }

        public bool IsUserLoggedIn(out User o_User)
        {
            bool isLoggedIn;

            if(!string.IsNullOrEmpty(m_AppSettings.LastAcessToken))
            {
                o_User = FacebookService.Connect(m_AppSettings.LastAcessToken)?.LoggedInUser;

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

            return isLoggedIn;
        }

        public User LoginUser()
        {
            LoginResult result = FacebookService.Login("451139335614057", "public_profile", "email", "publish_to_groups", "user_birthday", "user_age_range", "user_gender", "user_link", "user_tagged_places", "user_videos", "publish_to_groups", "groups_access_member_info", "user_friends", "user_events", "user_likes", "user_location", "user_photos", "user_posts", "user_hometown");

            if (result?.LoggedInUser != null)
            {
                if (RememberUser)
                {
                    m_AppSettings.SaveSettingsToXmlFile();
                }
            }
            else
            {
                throw new System.Exception("Login failed.");
            }

            return result.LoggedInUser;
        }

        public void LogoutUser()
        {
            m_AppSettings.DeleteAppSettings();
        }
    }
}
