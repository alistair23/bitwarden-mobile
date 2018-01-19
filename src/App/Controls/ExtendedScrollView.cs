using Xamarin.Forms;
using System;
using System.Reflection;

namespace Bit.App.Controls
{
    public class ExtendedScrollView : ScrollView
    {
        public static readonly BindableProperty EnableScrollingProperty =
            BindableProperty.Create(nameof(EnableScrolling), typeof(bool), typeof(ExtendedTableView), true);

        public bool EnableScrolling
        {
            get { return (bool)GetValue(EnableScrollingProperty); }
            set { SetValue(EnableScrollingProperty, value); }
        }
    }
}
