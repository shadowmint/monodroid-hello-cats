using System;

namespace Hello2.Infrastructure.MVC
{
	/** Responsible for launching an activity in the native code. */
	public interface IDispatcher
	{
		void Dispatch(ActionResult action);

		void StoreViewModel(Object model);

		Object GetViewModel();
	}
}

