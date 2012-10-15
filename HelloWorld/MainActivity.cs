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
	[Activity (Label = "Main", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			var r = new Resolver();
			r.Bind<IDispatcher, AndroidDispatcher>();
			r.Bind<ISession, AppSession>();

			var home = r.Resolve<HomeController>();
			home.Index();
		}
	}
}


