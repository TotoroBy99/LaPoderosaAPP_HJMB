using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace LaPoderosaAPP_HJMB
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btn_inicio, btn_historia, btn_mision;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btn_inicio = FindViewById<Button>(Resource.Id.Button1);
            btn_historia = FindViewById<Button>(Resource.Id.Button2);
            btn_mision = FindViewById<Button>(Resource.Id.Button3);

            btn_inicio.Click += Btn_inicio_Click;
            btn_historia.Click += Btn_historia_Click;
            btn_mision.Click += Btn_mision_Click;
        }

        private void Btn_inicio_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(Inicio_Activity));
            StartActivity(i);
        }

        private void Btn_historia_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(Historia_Activity));
            StartActivity(i);
        }

        private void Btn_mision_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(MisionVision_Activity));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            //Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}