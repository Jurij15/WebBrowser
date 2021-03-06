#define DEV_BUILD
//#undef DEV_BUILD
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Microsoft.Web.WebView2.Core;
using WebBrowser.SettingsFiles;
using WebBrowser.Windows;

namespace WebBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Preferences preferences = new Preferences();
            string home = preferences.HomePage;
            AdressBox.Text = home;
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(home);
                AdressBox.Text = home;
            }
            //favourites situation
            string setting = preferences.CanSeeFavouritesInMainWin;
            if (setting == "true")
            {
                FavouritesInMenu.Visibility = Visibility.Collapsed;
            }
            else if (setting == "false")
            {
                FavouritesBtnTest.Visibility = Visibility.Collapsed;
            }
#if (!DEV_BUILD)
            devtag.Visibility = Visibility.Collapsed;
#endif
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Environment.Exit(0);
            base.OnClosing(e);
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            Preferences preferences = new Preferences();
            string home = preferences.HomePage;
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(home);
                AdressBox.Text = home;
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            webView.GoBack();
        }

        private void ForwardBtn_Click(object sender, RoutedEventArgs e)
        {
            webView.GoForward();
        }

        private void ReloadBtn_Click(object sender, RoutedEventArgs e)
        {
            webView.Reload();
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            webView.Stop();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void GoBtn_Click(object sender, RoutedEventArgs e)
        {
            string adress = AdressBox.Text;
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(adress);;
            }
        }

        private void FavouritesBtnTest_Click(object sender, RoutedEventArgs e)
        {
            //open the window
            FavouritesWindow favouritesWindow = new FavouritesWindow();
            favouritesWindow.ShowDialog();
            favouritesWindow.Activate();
        }
        private void PreferencesBtn_Click(object sender, RoutedEventArgs e)
        {
            PreferencesWindow preferencesWindow = new PreferencesWindow();
            preferencesWindow.ShowDialog();
            preferencesWindow.Activate();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            Environment.Exit(0);
            //base.OnClosing(e);
        }

        private void SpecialsMenuBtn_Click(object sender, RoutedEventArgs e)
        {
            SpecialsWindow specialsWindow = new SpecialsWindow();
            specialsWindow.ShowDialog();
            specialsWindow.Activate();
        }
    }
}
