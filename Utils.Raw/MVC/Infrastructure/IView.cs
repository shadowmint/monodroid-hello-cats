using System;

namespace MVC.Infrastructure
{
	public interface IView
	{
		/** Get the controller for this view */
		Controller _Controller { get; }

		/** Get the model for this view */
		object _Model { get; }
	}
}

