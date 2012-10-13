using System;

namespace MVC.Infrastructure
{
	public abstract class Controller
	{
		protected ISession _session { get; private set; } 

		private IDispatcher _dispatcher;

		private Resolver _resolver;

		public Controller (ISession session, IDispatcher dispatcher, Resolver resolver)
		{
			_dispatcher = dispatcher;
			_session = session;
			_resolver = resolver;
		}

		protected void Navigate<T>(string id, object model) {
			_dispatcher.Dispatch(id, this, model);
		}
	}
}

