using System;

namespace MVC.Infrastructure
{
	public abstract class ISession
	{
		/** Return the global app state */
		public abstract object State { get; }
	}
}

