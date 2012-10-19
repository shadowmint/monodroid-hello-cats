using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HelloWorld.Models.Repo;

namespace HelloWorld.ViewModels.Home
{
	public class NoteViewModel 
	{
		public NoteViewModel(Note note) {
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Value { get; set; }
	}
}


