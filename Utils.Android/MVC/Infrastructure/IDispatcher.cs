using System;

namespace MVC.Infrastructure
{
	public interface IDispatcher
	{
	    /** Request that a view be launched from controller T with the given model */
		void Dispatch<T>(string id, object model, ISession session) where T : Controller;
	}
}

