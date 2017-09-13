using System;

using BlogEdit.UWP.Services;
using BlogEdit.UWP.Views;

using GalaSoft.MvvmLight.Ioc;

using Microsoft.Practices.ServiceLocation;

namespace BlogEdit.UWP.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<MainViewModel, MainPage>();
            Register<PagesViewModel, PagesPage>();
            Register<PagesDetailViewModel, PagesDetailPage>();
            Register<PostsViewModel, PostsPage>();
            Register<PostsDetailViewModel, PostsDetailPage>();
            Register<SettingsViewModel, SettingsPage>();
        }

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public PostsDetailViewModel PostsDetailViewModel => ServiceLocator.Current.GetInstance<PostsDetailViewModel>();

        public PostsViewModel PostsViewModel => ServiceLocator.Current.GetInstance<PostsViewModel>();

        public PagesDetailViewModel PagesDetailViewModel => ServiceLocator.Current.GetInstance<PagesDetailViewModel>();

        public PagesViewModel PagesViewModel => ServiceLocator.Current.GetInstance<PagesViewModel>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
