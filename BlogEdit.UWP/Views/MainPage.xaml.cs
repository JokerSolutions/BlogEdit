using System;

using BlogEdit.UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace BlogEdit.UWP.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
