using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MVC.Infrastructure;
using MVC.Infrastructure.Impl;
using HelloWorld.Model;
using HelloWorld.Controllers;

namespace HelloWorld
{
	[Activity (Label = "App", MainLauncher = true)]
	public class App : Activity
	{
		public static AppSession Session = null;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);



			/** Create global session instance */
			var r = new Resolver();


			Session.Controller<HomeController>().Index();
		}
	}
}


