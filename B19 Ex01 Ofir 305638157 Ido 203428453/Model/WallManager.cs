using System;
using FacebookWrapper.ObjectModel;

namespace Model
{
    public class WallManager
    {
        #region Class Members / Properties
        private FacebookObjectCollection<Post> m_Wall;
        private int                            m_PostIndex;
        private int                            m_CommentIndex;
        private int                            m_PicturePostCount;
        private string                         m_CurrCommentId;
        private string                         m_CurrPostId;
        #endregion

        #region Class Methods
        public WallManager(FacebookObjectCollection<Post> i_Wall)
        {
            m_Wall = i_Wall;
            m_PostIndex = -1;
            m_CommentIndex = 0;
            foreach (Post post in m_Wall)
            {
                if (post.Type == Post.eType.photo)
                {
                    m_PicturePostCount++;
                }
            }
        }

        public Post GetNextWallPost()
        {
            Post post;
            if (m_PicturePostCount == 0)
            {
                post = null;
            }
            else
            {
                m_CommentIndex = 0;
                if (m_PostIndex == m_Wall.Count - 1)
                {
                    m_PostIndex = 0;
                }

                post = m_Wall[++m_PostIndex];
                if (post.Type != Post.eType.photo)
                {
                    post = this.GetNextWallPost();
                }
            }

            m_CurrPostId = post.Link;

            return post;
        }

        public Comment GetNextCommentOfCurrentPost()
        {
            Comment comment;
            try
            {
                if (m_Wall[m_PostIndex].Comments.Count == 0)
                {
                    comment = null;
                    m_CurrCommentId = null;
                }
                else
                {
                    if (m_CommentIndex == m_Wall[m_PostIndex].Comments.Count)
                    {
                        m_CommentIndex = 0;
                    }

                    comment = m_Wall[m_PostIndex].Comments[m_CommentIndex++];
                    m_CurrCommentId = comment.Id;
                }
            }
            catch (Exception)
            {
                comment = null;
                m_CurrCommentId = null;
            }

            return comment;
        }
        
        public string GetCommentID()
        {
            return m_CurrCommentId;
        }

        public string GetPostId()
        {
            return m_CurrPostId;
        }

        public void PostToWall(User i_User, string i_PostText)
        {
            i_User.PostStatus(i_PostText);
        }
    }

    #endregion
}
