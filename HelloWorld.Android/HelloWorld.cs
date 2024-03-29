using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using n.Infrastructure;
using n.Infrastructure.Impl;
using HelloWorld.Model;
using HelloWorld.Controllers;

namespace HelloWorld
{
	[Activity (Label = "HelloWorld", MainLauncher = true)]
	public class HelloWorld : Activity
	{
		public static HelloWorldApp App = new HelloWorldApp();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			var target = HelloWorld.App.Controller<HomeController>(this).Index();
			HelloWorld.App.Activiate(target);
		}
	}
}


