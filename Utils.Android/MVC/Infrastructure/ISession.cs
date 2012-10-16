using System;
using System.Collections.Generic;

namespace MVC.Infrastructure
{
	public abstract class ISession
	{
		private Resolver _resolver = null;

		private ISession _instance = null;

		private IDictionary<Type, ViewData> _data = new Dictionary<Type, ViewData>();

		/** Get a resolver instance */
		public Resolver Resolver { 
			get {
				if (_resolver == null)
					_resolver = new Resolver();
				return _resolver;
			}
		}

		/** Return the global app state */
		public abstract object State { get; }

		/** Return an implementation specific dispatcher */
		public abstract IDispatcher IDispatcher();

		/** Return a controller instance */
		public T Controller<T>() where T : Controller {
			return _resolver.Resolve<T>();
		}

		/** Bind data to be loaded by a view later */
		public void SetViewData(Type type, ViewData data) {
			_data[type] = data;
		}

		/** Get some view data */
		public ViewData GetViewData(Type type) {
			return _data.ContainsKey(type) ? _data[type] : null;
		}
	}
}

