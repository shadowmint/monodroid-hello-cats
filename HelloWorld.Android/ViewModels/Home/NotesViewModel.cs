using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace HelloWorld.ViewModels.Home
{
	public class NotesViewModel 
	{
		public IEnumerable<NoteViewModel> Notes;
	}
}


