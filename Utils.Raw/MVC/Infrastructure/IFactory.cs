using System;

namespace MVC.Infrastructure
{
	/** Any implementation must be able to manufacture these types */
	public interface IFactory
	{
		IDispatcher IDispatcher();
		IView 
	}
}

