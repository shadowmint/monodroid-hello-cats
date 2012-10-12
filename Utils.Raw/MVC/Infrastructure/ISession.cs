using System;

namespace MVC.Infrastructure
{
	public interface ISession
	{
		/** Return the global app state */
		object _State { get; }
	}
}

