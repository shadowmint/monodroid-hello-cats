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
		private NotesViewModel _state;

		private NotesController _controller;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Notes);
			_controller = HelloWorld.App.Controller<NotesController>(this);
			_state = _controller.All().AsType<NotesViewModel>();

			Button add_button = FindViewById<Button> (Resource.Id.notesAddButton);
			add_button.Click += delegate {
				EditText nameText = FindViewById<EditText>(Resource.Id.notesNoteName);
				nameText.Text = "Hello World";
			};
		}
	}
}


