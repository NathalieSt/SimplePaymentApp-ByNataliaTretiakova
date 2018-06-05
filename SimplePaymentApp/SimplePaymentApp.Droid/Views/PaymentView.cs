using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V7.Widget;
using Acr.UserDialogs;

namespace SimplePaymentApp.Droid.Views
{
    [Activity(Label = "@string/ApplicationName")]
    public class PaymentView : MvxAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.payment_view);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            UserDialogs.Init(this);

        }
    }
}