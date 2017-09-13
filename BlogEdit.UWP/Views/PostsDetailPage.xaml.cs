using System;

using BlogEdit.UWP.Models;
using BlogEdit.UWP.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace BlogEdit.UWP.Views
{
    public sealed partial class PostsDetailPage : Page
    {
        private PostsDetailViewModel ViewModel
        {
            get { return DataContext as PostsDetailViewModel; }
        }

        public PostsDetailPage()
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
