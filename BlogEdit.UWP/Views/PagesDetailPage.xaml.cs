using System;

using BlogEdit.UWP.Models;
using BlogEdit.UWP.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace BlogEdit.UWP.Views
{
    public sealed partial class PagesDetailPage : Page
    {
        private PagesDetailViewModel ViewModel
        {
            get { return DataContext as PagesDetailViewModel; }
        }

        public PagesDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.Item = e.Parameter as SampleOrder;
        }
    }
}
