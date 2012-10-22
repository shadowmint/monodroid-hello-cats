using System;

namespace MVC.Infrastructure
{
	public interface IView
	{
		/** Return the data block for this view */
		nViewData ViewData { get; }
	}
}

