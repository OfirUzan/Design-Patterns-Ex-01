using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class MapForm : Form
    {
        private const string k_GoogleMapsUrl = "http://maps.google.com/maps?q=";

        public MapForm()
        {
            InitializeComponent();
        }

        internal void ShowLocationOnMap(string i_Location)
        {
            string url = k_GoogleMapsUrl + i_Location;
            webBrowserGoogleMap.Navigate(url);
        }
    }
}
