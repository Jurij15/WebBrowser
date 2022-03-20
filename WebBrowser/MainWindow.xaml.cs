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

        private void GoBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
