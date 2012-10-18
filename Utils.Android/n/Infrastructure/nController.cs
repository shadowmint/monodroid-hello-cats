using System;

namespace n.Infrastructure
{
	/** Extend this class for application controllers */
	public abstract class nController
	{
		/** The context from the calling view */
		private object _context;

		/** Factory for creating views */
		private nViewFactory _factory;

		/** Raw copy of the global application state */
		protected object _rawState;

		public nController() {
			var r = new nResolver();
			_factory = r.Resolve<nViewFactory>();
			_rawState = r.Resolve<nStateFactory>().State;
		}

		/** Return a view with only a model */
		protected nView View (object model)
		{
			var rtn = _factory.View(nViewType.MODEL_ONLY, model, _context);
			return rtn;
		}

		/** Return a view to navigate to the given type */
		protected nView View (Type target)
		{
			var rtn = _factory.View(nViewType.ACTION_ONLY, target, _context);
			return rtn;
		}

		/** Return a model and have a navigation result */
		protected nView View (object model, Type target)
		{
			var rtn = _factory.View(nViewType.MODEL_AND_ACTION, model, target, _context);
			return rtn;
		}

		/** Set the context the controller will need to use to create views */
		public void SetContext (object context)
		{
			_context = context;
		}
	}
}

