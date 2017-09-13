using System;

using BlogEdit.UWP.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BlogEdit.UWP.Views
{
    public sealed partial class PagesDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(PagesDetailControl), new PropertyMetadata(null));

        public PagesDetailControl()
        {
            InitializeComponent();
        }
    }
}
