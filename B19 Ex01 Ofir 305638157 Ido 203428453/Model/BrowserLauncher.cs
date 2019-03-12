using System.Diagnostics;

namespace Model
{
    public class BrowserLauncher
    {
        public void LaunchBrowser(string i_Url)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(i_Url);
            Process.Start(sInfo);
        }
    }
}
