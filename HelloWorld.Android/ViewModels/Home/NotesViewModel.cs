using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using HelloWorld.Models.Repo;

namespace HelloWorld.ViewModels.Home
{
	public class NotesViewModel 
	{
		public NotesViewModel(IEnumerable<Note> notes) {
		}

		public IEnumerable<NoteViewModel> Notes;
	}
}


