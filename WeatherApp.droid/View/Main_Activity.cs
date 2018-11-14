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
using MvvmCross.Droid.Views;
using WeatherApp.core.ViewModels;

namespace WeatherApp.droid.View
{
	[Activity(Label = "Main_Activity", MainLauncher =true)]
	public class Main_Activity : MvxActivity<MainViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
		}
	}
}