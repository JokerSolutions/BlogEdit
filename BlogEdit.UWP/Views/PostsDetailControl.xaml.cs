using System;

using BlogEdit.UWP.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BlogEdit.UWP.Views
{
    public sealed partial class PostsDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(PostsDetailControl), new PropertyMetadata(null));

        public PostsDetailControl()
        {
            InitializeComponent();
        }
    }
}
