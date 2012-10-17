using System;

namespace MVC.Infrastructure
{
	/** Return a global instance of the application state */
	public interface nStateFactory
	{
		/** Return the global application state */
		object State { get; }
	}
}

