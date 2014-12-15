using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Example81
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void firstBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page1));
        }

        private void secondBtn_Click(object sender, RoutedEventArgs e)
        {
            ((App.Current as App).MyAppBar.PrimaryCommands[0] as AppBarButton).Label = "New label";
        }
    }
}
