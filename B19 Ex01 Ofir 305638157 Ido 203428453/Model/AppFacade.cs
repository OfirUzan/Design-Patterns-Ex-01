using System;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class AppFacade
    {
        #region Class Members / Properties
        private class PictureBoxThread
        {
            public System.Threading.Thread Thread { get; set; }

            public int PictureBoxIndex { get; set; }
        }

        private AlbumsManager m_AlbumsManager;
        private FaceRideManager m_FaceRideManager;
        private FacebookAuthenticator m_FacebookAuthenticator;
        private WallManager m_WallManager;
        private const string k_AlbumCoverPhotosName = "Cover Photos";

        public User User { get; set; }

        public User Friend { get; set; }

        public User FaceRideFriend { get; set; }

        public bool RememberUser
        {
            get
            {
                return m_FacebookAuthenticator.RememberUser;
            }

            set
            {
                m_FacebookAuthenticator.RememberUser = value;
            }
        }
        #endregion

        #region Class Methods

        public AppFacade()
        {
            m_FacebookAuthenticator = new FacebookAuthenticator();
            m_FaceRideManager = new FaceRideManager();
        }

        private void startThreadsForAlbumsTabUpdate(Action<int> i_MethodToExecute, int i_NumOfPictureBoxes)
        {
            PictureBoxThread[] pictureBoxThreads = new PictureBoxThread[i_NumOfPictureBoxes];

            for (int i = 0; i < i_NumOfPictureBoxes; ++i)
            {
                pictureBoxThreads[i] = new PictureBoxThread();
                pictureBoxThreads[i].PictureBoxIndex = i;
            }

            foreach (PictureBoxThread pictureBoxThread in pictureBoxThreads)
            {
                pictureBoxThread.Thread = new System.Threading.Thread(() => i_MethodToExecute(pictureBoxThread.PictureBoxIndex));
                pictureBoxThread.Thread.Start();
            }
        }

        public void Init()
        {
            m_AlbumsManager = new AlbumsManager(User);
            m_WallManager = new WallManager(User.WallPosts);
        }

        public bool IsUserLoggedIn(out User o_User)
        {
            o_User = null;
            return m_FacebookAuthenticator.IsUserLoggedIn(out o_User);
        }

        public User LoginUser()
        {
            return m_FacebookAuthenticator.LoginUser();
        }

        public void LogoutUser()
        {
            m_FacebookAuthenticator.LogoutUser();
        }

        public string GetFacebookUserInfo(User i_User)
        {
            return string.Format(
@"Name: {0}
Gender: {1}
Birthday: {2}
Email: {3}
City: {4}
Education: {5}
Work: {6}
Status: {7}
About: {8}",
                i_User.Name,
                i_User.Gender,
                i_User.Birthday,
                i_User.Email,
                i_User.Hometown?.Name,
                i_User.Educations?[0].School?.Name,
                i_User.WorkExperiences?[0].Name,
                i_User.RelationshipStatus,
                i_User.About);
        }

        public string GetCoverPhotoURL()
        {
            return m_AlbumsManager.GetLatestPhotoURL(k_AlbumCoverPhotosName);

        }

        public Post GetNextWallPost()
        {
            return m_WallManager.GetNextWallPost();
        }

        public Comment GetNextCommentOfCurrentPost()
        {
            return m_WallManager.GetNextCommentOfCurrentPost();
        }

        public string GetPostId()
        {
            return m_WallManager.GetPostId();
        }

        public string GetCommentId()
        {
            return m_WallManager.GetCommentId();
        }

        public void SetCurrentAlbum(string i_AlbumName)
        {
            m_AlbumsManager.SetCurrentAlbum(i_AlbumName);
        }

        public string GetNextPhotoURL()
        {
            return m_AlbumsManager.GetNextPhotoURL();
        }

        public string GetPreviousPhotoURL()
        {
            return m_AlbumsManager.GetPreviousPhotoURL();
        }

        public string GetUserCurrentAdress()
        {
            return m_FaceRideManager.GetUserCurrentAdress();
        }

        public void SetFaceRideFriend(int i_RowIndex)
        {
            m_FaceRideManager.ChosenFriend = m_FaceRideManager.PossibleRideFriends[i_RowIndex];
        }

        public User GetFaceRideChosendFriend()
        {
            return m_FaceRideManager.ChosenFriend;
        }

        public FacebookObjectCollection<User> GetPotentialRideFriends(User i_User, string i_SearchRadius, bool i_MaleFriends, bool i_FemaleFriends)
        {
            return m_FaceRideManager.GetPotentialRideFriends(i_User, i_SearchRadius, i_MaleFriends, i_FemaleFriends);
        }

        public void UpdatePhotosOnAlbumsTab(Action<int> i_MethodToExecute, int i_NumOfPictureBoxes)
        {
            startThreadsForAlbumsTabUpdate(i_MethodToExecute, i_NumOfPictureBoxes);
        }

        public static void UploadAPhotoToTimeline(User i_User, string i_FilePath)
        {
            AlbumsManager.UploadAPhotoToTimeline(i_User, i_FilePath);
        }
        #endregion
    }
}