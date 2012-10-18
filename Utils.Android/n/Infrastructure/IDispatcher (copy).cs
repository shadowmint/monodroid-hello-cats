using System;

namespace MVC.Infrastructure
{
	/** The domain specific implementation should use a View to navigate to a new activity */
	public interface IDispatcher
	{
		/** Launch the acitivity that view refers to, if any */
		void Dispatch(nView view);
	}
}

