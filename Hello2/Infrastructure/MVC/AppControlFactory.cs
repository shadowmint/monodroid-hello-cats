using System;
using Hello2.Infrastructure.IOC;

namespace Hello2.Infrastructure.MVC
{
	public class AppControlFactory
	{
		public static void Register<T> (T instance) {
			var method = TinyIoCContainer.Current.GetType().GetMethod ("Register");
			var generic = method.MakeGenericMethod(typeof(T));
			generic.Invoke(TinyIoCContainer.Current, new object[] { instance });
		}

		public static T Resolve<T>() {
			var method = TinyIoCContainer.Current.GetType().GetMethod ("Resolve");
			var generic = method.MakeGenericMethod(typeof(T));
			var result = generic.Invoke(TinyIoCContainer.Current, new object[] {});
			return (T) result;
		}
	}
}

