using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using n.Infrastructure;
using HelloWorld.ViewModels.Home;
using HelloWorld.Model;

namespace HelloWorld.Controllers
{
	public abstract class ControllerBase : nController
	{
		protected HelloWorldState _state {
			get {
				return (HelloWorldState) _stateFactory.State;
			}
		}
	}
}


