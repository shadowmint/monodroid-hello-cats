using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using n.Infrastructure;
using HelloWorld.ViewModels.Home;
using HelloWorld.Views.Home;
using System.Collections.Generic;
using HelloWorld.Models.Repo;

namespace HelloWorld.Controllers
{
	public class NotesController : ControllerBase
	{
		private NoteRepo _repo;

		public NotesController(NoteRepo repo) {
			_repo = repo;
		}

		public nView All() {
			var all = _repo.All(20, 0);
			var model = new NotesViewModel(all);
			return View(model);
		}

		public nView Add(string name, string value)
		{
			var item = _repo.Create(name, value);
			var model = new NoteViewModel(item);
			return View(model);
		}

		public nView Remove(int id) {
			var item = _repo.Get(id);
			_repo.Delete(item);
			return View (true);
		}
	}
}


