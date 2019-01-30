using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FirstApp;
using FirstApp.Droid.Models;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ButtonControl), typeof(MyButtonRender))]
[assembly: ExportRenderer(typeof(EntryControl), typeof(MyEntryRender))]

namespace FirstApp.Droid.Models
{
    public class MyButtonRender : ButtonRenderer
    {
        public MyButtonRender(Context context) : base(context)
        {
            Toast.MakeText(context, "My App Btn render called", ToastLength.Short).Show();
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
                Control.SetBackgroundResource(Resource.Drawable.btn_background);
            }
        }



    }

    public class MyEntryRender : EntryRenderer
    {
        public MyEntryRender(Context context) : base(context)
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
                Control.SetBackgroundResource(Resource.Drawable.DrawableBack);
            }
        }
    }
}