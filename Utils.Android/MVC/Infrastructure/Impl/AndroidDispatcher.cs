using System;
using MVC.Infrastructure;
using System.Collections.Generic;
using Android.Content;

namespace MVC.Infrastructure.Impl
{
	public class AndroidDispatcher : IDispatcher
	{
		public static ViewData ViewData;

		private Resolver _resolver = new Resolver();

		public void Dispatch<T>(string id, object state) where T : Controller
		{
			var context = (Context) state;
			var controller = (Controller)_resolver.Resolve<T>();
			ViewData = new ViewData() {
				State = state,
				Controller = controller
			};

			var intent = new Intent(id);
			context.StartActivity(intent);
		}
	}
}

