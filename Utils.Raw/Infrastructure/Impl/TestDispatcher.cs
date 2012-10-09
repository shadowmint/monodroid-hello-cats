using System;
using Hello2.Infrastructure.MVC;

namespace Utils
{
	public class TestDispatcher : IDispatcher
	{
		public static IView View;

		private Object _model;

		public void Dispatch(ActionResult action, Object context) {
			_model = action.Model;
			View = (IView) Activator.CreateInstance(action.View);
		}

		public void StoreViewModel (object model)
		{
			_model = model;
		}
		
		public object GetViewModel ()
		{
			return _model;
		}
	}
}

