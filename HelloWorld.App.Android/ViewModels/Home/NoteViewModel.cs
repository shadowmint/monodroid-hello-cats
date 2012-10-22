using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HelloWorld.Models.Repo;
using n.Infrastructure;

namespace HelloWorld.ViewModels.Home
{
	public class NoteViewModel : nModel
	{
		public NoteViewModel()
		{
		}

		public NoteViewModel(Note note)
		{
			Id = note.Id;
			Name = note.Name;
			Value = note.Value;
			Valid = note.Valid;
			Messages = "";
			if (!Valid) {
				foreach (var m in note.Errors.Messages) {
					Messages += m + "\n";
				}
			}
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Value { get; set; }
		public bool Valid { get; set; }
		public string Messages { get; set; }
	}
}


