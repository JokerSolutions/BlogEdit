using System;

using BlogEdit.UWP.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace BlogEdit.UWP.Views
{
    public sealed partial class PagesPage : Page
    {
        private PagesViewModel ViewModel
        {
            get { return DataContext as PagesViewModel; }
        }

        public PagesPage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.LoadDataAsync(WindowStates.CurrentState);
        }
    }
}
