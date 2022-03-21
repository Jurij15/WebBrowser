using System;
using System.Collections;
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
using System.Windows.Shapes;
using WebBrowser.SettingsFiles;

namespace WebBrowser.Windows
{
    /// <summary>
    /// Interaction logic for FavouritesWindow.xaml
    /// </summary>
    public partial class FavouritesWindow : Window
    {
        
        private ArrayList LoadListBoxData()
        {
            ArrayList itemsList = new ArrayList();
            itemsList.Add("Fav1");
            itemsList.Add("Fav2");
            itemsList.Add("Fav3");
            itemsList.Add("Fav4");
            itemsList.Add("Fav5");
            itemsList.Add("Fav6");
            return itemsList;
        }
        public FavouritesWindow()
        {
            InitializeComponent();
            //FavListBox.ItemsSource = LoadListBoxData();
        }

        private void Fav1InList_Selected(object sender, RoutedEventArgs e)
        {
            Favourites favourites = new Favourites();
            FavAdressBox.Text = favourites.Fav1;
        }

        private void OpenSelFav_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            //main.webView webView = main.webView();
            //main.webView.CoreWebView2.Navigate(FavAdressBox.Text);
            string adress = FavAdressBox.Text;
            if (main.webView != null && main.webView.CoreWebView2 != null)
            {
                main.webView.CoreWebView2.Navigate(adress);
            }
        }

        private void ShowSelFav_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
