using System.Windows.Forms;

namespace View
{
    public partial class LargePhotoForm : Form
    {
        #region Class Members / Properties
        public PictureBox Picture
        {
            get
            {
                return m_pictureBox;
            }

            set
            {
                m_pictureBox = value;
            }
        }
        #endregion

        #region Class Methods
        public LargePhotoForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}
