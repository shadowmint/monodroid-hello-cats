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
using HelloWorld.ViewModels.Home;

namespace HelloWorld.Views.Home
{
	[Activity (Label = "HelloWorld.Views.Home.HelloView1")]
	public class HelloView1 : Activity
	{
		private IndexViewModel _state;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);
			_state = (IndexViewModel) HelloWorld.App.Controller<HomeController>(ApplicationContext).Hello().Model;

			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", _state.Count++);
			};
		}
	}
}


