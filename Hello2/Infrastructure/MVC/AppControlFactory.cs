using System;
using Hello2.Infrastructure.IOC;

namespace Hello2.Infrastructure.MVC
{
	public class AppControlFactory
	{
		private static AppControl _instance = null;

		public AppControl Get ()
		{
			if (_instance == null) _instance = Resolve<AppControl>();
			return _instance;
		}

		public static void Register<T> (T instance) {
			TinyIoCContainer.Current.Register<T>(instance);
		}

		public static T Resolve<T>() {
			return TinyIoCContainer.Current.Resolve<T>();
		}
	}
}

