using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace GameLauncher
{
    class Launcher
    {
        public static void PlayGame()
        {

            Process.Start("game.exe");
         
        }

        public static void LaunchWebSite(string url)
        {

            ///  Process.Start(url);
            System.Diagnostics.Process.Start("http://www.facebook.com");
            
        }


    }
}
