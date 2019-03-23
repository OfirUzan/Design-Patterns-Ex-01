using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class AlbumsManager
    {
        #region Members / Properties
        private readonly object r_getNextPhotoLockContext = new object();

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
            lock (r_getNextPhotoLockContext)
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

        /* // like counters
         private int sumAlbumLikes(Album i_Album)
         {
             int res = 0;
             foreach (var p in i_Album.Photos)
             {
                 res += sumPhotoLikes(p);
             }

             return res;
         }
         
         private int sumPhotoLikes(Photo i_Photo)
         {
             int res = 0;
             foreach (var like in i_Photo.LikedBy)
             {
                 res++;
             }

             return res;
         }

         private void countLikesOfPhotoByGender(Photo i_Photo, ref int r_MaleCount, ref int r_FemaleCount)
         {
             r_MaleCount = 0;
             r_FemaleCount = 0;
             foreach (var like in i_Photo.LikedBy)
             {
                 if (like.Gender == User.eGender.male)
                 {
                     r_MaleCount++;
                 }
                 else if (like.Gender == User.eGender.female)
                 {
                     r_FemaleCount++;
                 }

             }
         }

         private void countLikesOfAlbumByGender(Album i_Album, ref int r_MaleCount, ref int r_FemaleCount)
         {
             r_MaleCount = 0;
             r_FemaleCount = 0;
             foreach (var photo in i_Album.Photos)
             {
                 int male = 0, female = 0;
                 countLikesOfPhotoByGender(photo, ref male, ref female);
                 r_MaleCount += male;
                 r_FemaleCount += female;
             }
         }



         private string mostLikedPictureFromAlbum(string i_AlbumName)
         {
             int maxLikes = 0;
             Photo res = null;

             Album profilePicAlbum = m_User.Albums.Find(x => x.Name == i_AlbumName);
             if (profilePicAlbum == null)
             {
                 // Album Not Found Exeption
             }
             else
             {
                 foreach (var p in profilePicAlbum.Photos)
                 {
                     if (sumPhotoLikes(p) > maxLikes)
                     {
                         res = p;
                     }
                 }
             }

             return res.Pictures.PictureUrl;
         }*/
    }
}
