using System;

namespace MVC.Infrastructure
{
	public interface IDispatcher
	{
	    /** Request that a view be launched, passing it the controller and model */
		void Dispatch(string id, Controller controller, object model);
	}
}

