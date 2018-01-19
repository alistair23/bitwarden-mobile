using System;
using System.ComponentModel;
using Bit.App.Controls;
using Bit.UWP.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

[assembly: ExportRenderer(typeof(ExtendedScrollView), typeof(ExtendedScrollViewRenderer))]
namespace Bit.UWP.Controls
{
    public class ExtendedScrollViewRenderer : ScrollViewRenderer
    {
        public override SizeRequest GetDesiredSize(double widthConstraint, double heightConstraint)
        {
            var baseSize = new Size(Control.Width, Control.Height);
            return new SizeRequest(new Size(baseSize.Width, 300));
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ScrollView> e)
        {
            base.OnElementChanged(e);

            var view = e.NewElement as ScrollView;
            if(view != null)
            {
                // SetScrolling(view);
                Control.VerticalAlignment = VerticalAlignment.Top;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var view = (ExtendedScrollView)Element;

            if(e.PropertyName == ExtendedTableView.EnableScrollingProperty.PropertyName)
            {
                // SetScrolling(view);
                Control.VerticalAlignment = VerticalAlignment.Top;
            }
        }

        private void SetScrolling(ScrollView view)
        {
            Control.VerticalScrollMode = ScrollMode.Disabled;
            Control.HorizontalScrollMode = ScrollMode.Disabled;
        }
    }
}
