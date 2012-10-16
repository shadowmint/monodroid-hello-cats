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
using HelloWorld.Model;

namespace HelloWorld.Controllers
{
	public abstract class ControllerBase : Controller
	{
		public ControllerBase(ISession session, IDispatcher dispatcher) : base(session, dispatcher) {
		}

		protected AppModel Model {
			get {
				return (AppModel) Session.State;
			}
		}
	}
}


