using System;
using System.Collections.Generic;

namespace Hello2.Infrastructure.MVC
{
	public class AppControl
	{
		private IDictionary<string, Route> _routes = new Dictionary<string, Route>();

		private IDictionary<Type, IController> _controllers = new Dictionary<Type, IController>();

		private IDispatcher _dispatcher;

		private IController _controller;

		public AppControl (IDispatcher dispatcher)
		{
			_dispatcher = dispatcher;
		}

		/** Get a specific controller */
		public IController Controller (Type ctype)
		{
			if (!_controllers.ContainsKey (ctype)) {
				var controller = (IController) AppControlFactory.Resolve (ctype);
				_controllers.Add(ctype, controller);
			}
			return _controllers [ctype];
		}

		/** Bind an action to a named route */
		public void Route<T> (T controller, IControllerAction action, string path) where T : IController
		{
			var route = new Route() {
				Path = path,
				Controller = controller,
				Action = action
			};
			_routes.Add(path, route);
		}

		/** Attempts to navigate to a new controller */
		public void Navigate (string path)
		{
			if (_routes.ContainsKey (path)) {
				var route = _routes[path];
				var action = route.Action();
				_controller = route.Controller;
				_dispatcher.Dispatch(action, _controller.Context);
			}
		}

		/** Get the current view model from any context */
		public T ViewModel<T> (Object context)
		{
			_controller.Context = context;
			return (T) _dispatcher.GetViewModel();
		}
	}
}

