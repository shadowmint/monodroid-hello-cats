using System;
using MVC.Infrastructure;
using System.Collections.Generic;

namespace MVC.Infrastructure.Impl
{
	public class AndroidDispatcher : IDispatcher
	{
		private static IDictionary<string, TestView> _views = new Dictionary<string, TestView>();

		private Resolver _resolver = new Resolver();

		public static ViewData ViewData { get; private set; }

		public static TestView CurrentView = null;

		/** For testing, you must explicitly bind views to ids */
		public static void Bind(string id, TestView instance)
		{
			_views[id] = instance;
		}

		public void Dispatch<T>(string id, object state) where T : Controller
		{
			var controller = (Controller)_resolver.Resolve<T>();
			ViewData = new ViewData() {
				State = state,
				Controller = controller
			};
			if (!_views.ContainsKey(id)) {
				throw new Exception("In testing you MUST manually register views to their ID's using TestDispatcher::Bind (missing id: " + id + ")");
			}
			CurrentView = _views[id];
		}
	}
}

