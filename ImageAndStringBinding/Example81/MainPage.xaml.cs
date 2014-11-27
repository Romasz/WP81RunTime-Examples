using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private string imgArt;

        public string ImgArt
        {
            get { return imgArt; }
            set { imgArt = value; OnPropertyChanged("ImgArt"); }
        }
        

        ObservableCollection<string> commands = new ObservableCollection<string>();

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = this;
        }

        private void firstBtn_Click(object sender, RoutedEventArgs e)
        {
            ImgArt = "ms-appx:///test.jpg";
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
