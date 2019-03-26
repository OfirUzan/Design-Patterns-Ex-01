using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class AlbumsManager
    {
        #region Members / Properties
        private readonly object r_GetNextPhotoLockContext = new object();

        public User User { get; set; }

        public LinkedListNode<string> CurrentPhotoURL { get; set; }

        public LinkedList<string> CurrentAlbumPhotosURL { get; set; }  
        #endregion

        #region Class Methods
        public AlbumsManager(User i_User)
        {
            CurrentAlbumPhotosURL = new LinkedList<string>();
            User = i_User;
        }

        public string GetLatestPhotoURL(string i_AlbumName)
        {
            Album photosAlbum = User.Albums.Find(x => x.Name == i_AlbumName);
            Photo latestPhoto = photosAlbum.Photos[0];

            return latestPhoto.PictureNormalURL;
        }

        public string GetNextPhotoURL()
        {
            string nextPhotoURL;
            lock (r_GetNextPhotoLockContext)
            {
                if (CurrentPhotoURL.Next != null)
                {
                    nextPhotoURL = CurrentPhotoURL.Next.Value;
                    CurrentPhotoURL = CurrentPhotoURL.Next;
                }
                else
                {
                    nextPhotoURL = CurrentAlbumPhotosURL.First.Value;
                    CurrentPhotoURL = CurrentAlbumPhotosURL.First;
                }
            }

            return nextPhotoURL;
        }

        public string GetPreviousPhotoURL()
        {
            string previousPhotoURL;
            if (CurrentPhotoURL.Previous != null)
            {
                previousPhotoURL = CurrentPhotoURL.Previous.Value;
                CurrentPhotoURL = CurrentPhotoURL.Previous;
            }
            else
            {
                previousPhotoURL = CurrentAlbumPhotosURL.Last.Value;
                CurrentPhotoURL = CurrentAlbumPhotosURL.Last;
            }

            return previousPhotoURL;
        }

        public void SetCurrentAlbum(string i_AlbumName)
        {
            CurrentAlbumPhotosURL.Clear();
            Album photosAlbum = User.Albums.Find(x => x.Name == i_AlbumName);
            
            foreach (Photo photo in photosAlbum.Photos)
            {
                CurrentAlbumPhotosURL.AddLast(photo.PictureNormalURL);
            }

            CurrentPhotoURL = CurrentAlbumPhotosURL.First;
        }

        public void UploadAPhotoToTimeline(User i_User, string i_FilePath)
        {
            i_User.PostPhoto(i_FilePath);
        }
        #endregion
    }
}
