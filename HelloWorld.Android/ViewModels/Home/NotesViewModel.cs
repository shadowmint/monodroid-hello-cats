using System;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using HelloWorld.Models.Repo;
using n.Infrastructure;

namespace HelloWorld.ViewModels.Home
{
	public class NotesViewModel : nModel
	{
		public NotesViewModel(IEnumerable<Note> notes) {
			Notes = from n in notes select new NoteViewModel(n);
		}

		public IEnumerable<NoteViewModel> Notes;
	}
}


