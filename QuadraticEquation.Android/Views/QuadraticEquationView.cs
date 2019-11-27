using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using QuadraticEquation.Android;
using QuadraticEquations.Core.ViewModels;

namespace QuadraticEquation.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class QuadraticEquationView : MvxActivity<QuadraticEquationViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.QuadraticEquationPage);
        }
    }
}