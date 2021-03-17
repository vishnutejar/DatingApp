using DatingApp.iOS.CustomRenderer;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntryRenderer), typeof(CustomEntryRenderer))]
namespace DatingApp.iOS.CustomRenderer
{
    public class CustomEntryRenderer : EntryRenderer, IUITextFieldDelegate
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.Layer.BorderColor = UIColor.Red.CGColor;
            Control.Layer.BorderWidth = 1;
        }

    }
}