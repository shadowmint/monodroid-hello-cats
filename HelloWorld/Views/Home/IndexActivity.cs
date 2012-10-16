using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MVC.Infrastructure.Impl;
using HelloWorld.ViewModels.Home;
using HelloWorld.Controllers;

namespace HelloWorld.Views.Home
{
	[Activity (Label = IndexActivity.ID)]
	public class IndexActivity : AndroidView
	{
		public const string ID = "Home.Index";

		private IndexViewModel _model;

		private HomeController _controller; 

		protected void init() {
			_model = (IndexViewModel) ViewData.State;
			_controller = (HomeController) ViewData.Controller;
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			init();

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
				button.Text = _model.Value + string.Format ("{0} clicks!", _model.Count++);
			};
		}
	}
}


