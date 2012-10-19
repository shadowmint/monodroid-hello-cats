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

namespace HelloWorld.Controllers
{
	public class HomeController : ControllerBase
	{
		public nView Index() {
			return View(typeof(HelloView1));
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


