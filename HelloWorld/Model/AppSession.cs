using System;
using MVC.Infrastructure;

namespace HelloWorld.Model
{
	public class AppSession : ISession 
	{
		private static AppModel _instance = null;

		/** Bind various implementations */
		public AppSession() {
			var r = new Resolver();
			r.Bind<IDispatcher, AndroidDispatcher>();
			r.Bind<ISession, AppSession>();
		}

		public override object State {
			get {
				if (_instance == null)
					_instance = new AppModel();
				return _instance;
			}
		}
	}
}

