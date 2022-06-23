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

namespace LaPoderosaAPP_HJMB
{
    [Activity(Label = "Inicio_Activity")]
    public class Inicio_Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here

            SetContentView(Resource.Layout.Inicio_Layout);
        }
    }
}