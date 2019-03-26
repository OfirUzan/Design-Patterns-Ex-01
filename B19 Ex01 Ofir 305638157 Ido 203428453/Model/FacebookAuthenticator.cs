using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace Model
{
    public class FacebookAuthenticator
    {
        #region Class Members / Properties
        private const string             k_AppId = "451139335614057";
        private static readonly string[] sr_Premmisions = { "public_profile", "email", "publish_to_groups", "user_birthday", "user_age_range", "user_gender", "user_link", "user_tagged_places", "user_videos", "publish_to_groups", "groups_access_member_info", "user_friends", "user_events", "user_likes", "user_location", "user_photos", "user_posts", "user_hometown" };
        private AppSettings              m_AppSettings;
        public bool RememberUser { get; set; } = false;
        #endregion

        #region Class Methods
        public FacebookAuthenticator()
        {
            m_AppSettings = AppSettings.GetOrCreateAppSettingsFromXmlFile();
        }

        public bool IsUserLoggedIn(out User o_User)
        {
            bool isLoggedIn;

            if(!string.IsNullOrEmpty(m_AppSettings.LastAcessToken))
            {
                o_User = FacebookService.Connect(m_AppSettings.LastAcessToken).LoggedInUser;
                isLoggedIn = true;
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
            LoginResult result = FacebookService.Login(k_AppId, sr_Premmisions);
            m_AppSettings.LastAcessToken = result.AccessToken;

            if (result?.LoggedInUser != null)
            {
                if (RememberUser)
                {
                    m_AppSettings.SaveAppSettingsToXmlFile();
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
            m_AppSettings.DeleteAppSettingsXmlFile();
        }
        #endregion
    }
}
