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
	[Activity (Label = "HelloWorld.Views.Home.NotesView")]
	public class NotesView : Activity
	{
		private IndexViewModel _state;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Notes);
			_state = (IndexViewModel) HelloWorld.App.Controller<HomeController>(this).Hello().Model;

			Button button = FindViewById<Button> (Resource.Id.myButton);
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", _state.Count++);
			};
		}
	}
}


