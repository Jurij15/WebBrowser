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
using System.Windows.Shapes;
using WebBrowser.SettingsFiles;

namespace WebBrowser.Windows
{
    /// <summary>
    /// Interaction logic for PreferencesWindow.xaml
    /// </summary>
    public partial class PreferencesWindow : Window
    {
        public PreferencesWindow()
        {
            InitializeComponent();
            ///set all settings to match saved
            //checkbox
            Preferences preferences = new Preferences();
            string favsettthing = preferences.CanSeeFavouritesInMainWin;
            if (favsettthing == "true")
            {
                FavCheckBox.IsChecked = true;
            }
            else if (favsettthing == "false")
            {
                FavCheckBox.IsChecked= false;
            }
            //textbox adress set
            string home = preferences.HomePage;
            Homepage_AdressBox.Text = home;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Preferences preferences = new Preferences();

        }
    }
}
