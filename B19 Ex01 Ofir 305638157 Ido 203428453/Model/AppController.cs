using System;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class AppController
    {
        #region Class Members / Properties
        private class PictureBoxThread
        {
            public System.Threading.Thread Thread { get; set; }

            public int PictureBoxIndex { get; set; }
        }

        public User User { get; set; }

        public User Friend { get; set; }

        public User FaceRideFriend { get; set; }
        #endregion

        #region Class Methods
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

        public void UpdatePhotosOnAlbumsTab(Action<int> i_MethodToExecute, int i_NumOfPictureBoxes)
        {
            startThreadsForAlbumsTabUpdate(i_MethodToExecute, i_NumOfPictureBoxes);
        }
        #endregion
    }
}
