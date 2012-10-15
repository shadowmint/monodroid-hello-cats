using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MVC.Infrastructure;
using HelloWorld.ViewModels.Home;
using HelloWorld.Views.Home;

namespace HelloWorld.Controllers
{
	public class HomeController : Controller
	{
		public void Index() {
			Navigate<HomeController>(IndexActivity.ID, new IndexViewModel() { Value = "Hello World" });
		}
	}
}


