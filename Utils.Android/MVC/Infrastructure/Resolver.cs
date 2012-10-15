using System;
using MVC.Infrastructure.IOC;

namespace MVC.Infrastructure
{
	public class Resolver
	{
		public T Resolve<T>() where T : class {
			var rtn = (T) TinyIoCContainer.Current.Resolve<T>();
			return rtn;
		}

		public void Bind<T, K>() where T : class where K : T {
			var instance = Resolve<K>();
			TinyIoCContainer.Current.Register<T>(instance);
		}
	}
}

