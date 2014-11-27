using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        ObservableCollection<string> commands = new ObservableCollection<string>();

        public MainPage()
        {
            this.InitializeComponent();
        }

        CommandBar previousBar;
        private void HideBar()
        {
            previousBar = BottomAppBar as CommandBar;
            BottomAppBar = null;
        }

        private void ShowBar()
        {
            BottomAppBar = previousBar;
        }

        private void firstBtn_Click(object sender, RoutedEventArgs e)
        {
            BottomAppBar.IsOpen = true;
        }

        private async void secondBtn_Click(object sender, RoutedEventArgs e)
        {
            BottomAppBar.IsOpen = false;
        }
    }
}
