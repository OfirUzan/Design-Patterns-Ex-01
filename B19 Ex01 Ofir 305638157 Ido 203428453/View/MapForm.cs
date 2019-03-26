using System.Windows.Forms;

namespace View
{
    public partial class MapForm : Form
    {
        #region Class Members / Properties
        private const string k_GoogleMapsUrl = "http://maps.google.com/maps?q=";
        #endregion

        #region Class Methods
        public MapForm()
        {
            InitializeComponent();
        }

        internal void ShowLocationOnMap(string i_Location)
        {
            string url = k_GoogleMapsUrl + i_Location;
            webBrowserGoogleMap.Navigate(url);
        }
        #endregion
    }
}
