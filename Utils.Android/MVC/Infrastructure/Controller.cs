using System;

namespace MVC.Infrastructure
{
	public abstract class Controller
	{
		protected ISession Session { get; private set; }

		private IDispatcher _dispatcher;

		public Controller(ISession session, IDispatcher dispatcher)
		{
			_dispatcher = dispatcher;
			Session = session;
		}

		protected void Navigate<T>(string id, object model) where T : Controller
		{
			_dispatcher.Dispatch<T>(id, model);
		}
	}
}

