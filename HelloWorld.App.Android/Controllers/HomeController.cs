using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using n.Infrastructure;
using HelloWorld.ViewModels.Home;
using System.Collections.Generic;

namespace HelloWorld.Controllers
{
	public class HomeController : ControllerBase
	{
		public const string INDEX = "HELLO_VIEW_1";

		public nView Index() {
			return View(HomeController.INDEX);
		}

		public nView Notes() {
			return View(NotesController.INDEX);
		}

		public nView Hello() {
			++_state.Count;
			return View(new IndexViewModel() {
				Count = _state.Count,
				Value = "Hello"
			});
		}
	}
}


