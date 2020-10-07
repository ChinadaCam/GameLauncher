using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace GameLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void LaunchSiteBtn_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebSite("https://2vorvjknbrvtpgksqyrhyg-on.drv.tw/LimeSqueeze/GameLauncher/WebUpdates.html");
        }

        private void LaunchGameBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }
}
