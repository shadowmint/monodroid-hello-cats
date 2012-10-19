using System;

namespace n.Infrastructure
{
	/** Controller actions should always return a view object */
	public abstract class nView
	{
		/** Typed version of the model object */
		public T AsType<T> ()
		{
			return (T) Model;
		}

		/** The model returned by the controller */
		public object Model { get; protected set; }

		/** Any navigation information from the controller */
		public nAction Action { get; protected set; }

		/** If there is an action for this view */
		public bool HasAction { get { return Action != null; } }
	}
}

