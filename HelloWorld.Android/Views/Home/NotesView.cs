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
using System.Collections.Generic;

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
			populateList();

			Button add_button = FindViewById<Button> (Resource.Id.notesAddButton);
			add_button.Click += delegate {
				var name = FindViewById<EditText>(Resource.Id.notesNoteName).Text;
				var value = FindViewById<EditText>(Resource.Id.notesNoteValue).Text;
				_controller.Add(name, value);
				populateList();
			};
		}

		private void populateList() {
			var list = FindViewById<ListView>(Resource.Id.notesList);

			var dummy =  new List<NoteViewModel>() {
				new NoteViewModel() { Id = 0, Name = "Hello", Value = "World" },
				new NoteViewModel() { Id = 1, Name = "Hello2", Value = "World2" }
			};

			list.Adapter = new NotesListAdapter(this, Resource.Layout.Note, dummy);
		}
	}

	/** List builder */
	public class NotesListAdapter : ArrayAdapter<NoteViewModel> {

		private LayoutInflater _inflator;

		private NoteViewModel[] _notes;

		private int _resourceId;

		public NotesListAdapter(Context ctx, int viewResourceId, IEnumerable<NoteViewModel> notes) : base(ctx, viewResourceId) {
			_inflator = (LayoutInflater) ctx.GetSystemService(Context.LayoutInflaterService);
			_notes = new List<NoteViewModel>(notes).ToArray();
			_resourceId = viewResourceId;
		}

		public override int Count {
			get {
				return _notes.Length;
			}
		}

		public override long GetItemId(int position)
		{
			return _notes[position].Id;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			convertView = _inflator.Inflate(_resourceId, null);
			convertView.FindViewById<TextView>(Resource.Id.noteListName).Text = _notes[position].Name;
			convertView.FindViewById<TextView>(Resource.Id.noteListValue).Text = _notes[position].Value;
			return convertView;
		}
	}
}


