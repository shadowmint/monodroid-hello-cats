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
using Android.Views.InputMethods;

namespace HelloWorld.Views.Home
{
	[Activity (Label = "HelloWorld.Views.Home.NotesView")]
	public class NotesView : Activity
	{
		private NotesController _controller;

		private NotesActions _actions; 

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Notes);
			_controller = HelloWorld.App.Controller<NotesController>(this);
			_actions = new NotesActions(this, _controller);
			_actions.populateList();

			Button add_button = FindViewById<Button> (Resource.Id.notesAddButton);
			add_button.Click += delegate {

				var name = FindViewById<EditText>(Resource.Id.notesNoteName);
				var value = FindViewById<EditText>(Resource.Id.notesNoteValue);
				var note = (NoteViewModel) _controller.Add(name.Text, value.Text).Model;
				FindViewById<TextView>(Resource.Id.notesInfo).Text = note.Messages;

				if (note.Valid) {
					_actions.populateList();

					// Reset fields and hide keyboard on add
					HideKeyboard();
					name.Text = "";
					value.Text = "";
				}
			};
		}

		private void HideKeyboard() {
			var service = (InputMethodManager) GetSystemService(Context.InputMethodService);
			var field = FindViewById<EditText>(Resource.Id.notesNoteName);
			service.HideSoftInputFromWindow(field.WindowToken, 0);
		}
	}

	class NotesActions {

		private NotesView _self;

		public NotesController Controller;

		public NotesActions(NotesView view, NotesController controller) {
			_self = view;
			Controller = controller;
		}

		public void populateList() {
			var list = _self.FindViewById<ListView>(Resource.Id.notesList);
			var notes = Controller.All().Model.As<NotesViewModel>();
			list.Adapter = new NotesListAdapter(this, _self, Resource.Layout.Note, notes.Notes);
		}
	}

	/** List builder */
	class NotesListAdapter : ArrayAdapter<NoteViewModel> {

		private LayoutInflater _inflator;

		private NotesActions _actions;

		private NoteViewModel[] _notes;

		private int _resourceId;

		public NotesListAdapter(NotesActions actions, Context ctx, int viewResourceId, IEnumerable<NoteViewModel> notes) : base(ctx, viewResourceId) {
			_actions = actions;
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

			var button = convertView.FindViewById<Button>(Resource.Id.noteListDel);
			var pos = position;
			button.Click += delegate(object sender, EventArgs e) {
				_actions.Controller.Remove(_notes[pos].Id);
				_actions.populateList();
			};

			return convertView;
		}
	}
}


