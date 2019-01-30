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
using FirstApp.Droid.Models;
using FirstApp.Models;
using Xamarin.Forms;

[assembly:Dependency(typeof(DisplayToast))]

namespace FirstApp.Droid.Models
{
    public class DisplayToast : Imessage
    {
        public void showMessage(string msg)
        {
            Toast.MakeText(Android.App.Application.Context, msg, ToastLength.Short).Show();
        }
    }
}