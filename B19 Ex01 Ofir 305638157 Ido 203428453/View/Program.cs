using System;
using System.Windows.Forms;

namespace View
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppForm desktopFacebook = new AppForm();
            desktopFacebook.StartLoginSession();
        }
    }
}