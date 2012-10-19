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
using HelloWorld.ViewModels.Home;

namespace HelloWorld.Views.Home
{
	[Activity (Label = "HelloWorld.Views.Home.HelloView1")]
	public class HelloView1 : Activity
	{
		private HomeController _controller;
		private IndexViewModel _state;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);
			_controller = HelloWorld.App.Controller<HomeController>(this);
			_state = _controller.Hello().AsType<IndexViewModel>();

			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", _state.Count++);
			};

			button = FindViewById<Button> (Resource.Id.buttonToNotes);
			button.Click += delegate {
				HelloWorld.App.Activiate(_controller.Notes());
			};
		}
	}
}


