using System;

namespace MVC.Infrastructure
{
	public abstract class View
	{
		/** Return the data block for this view */
		protected abstract ViewData ViewData { get; }
	}
}

