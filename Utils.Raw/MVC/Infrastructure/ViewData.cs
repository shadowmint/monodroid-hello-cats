using System;

namespace MVC.Infrastructure
{
	public class ViewData
	{
		/** Controller for this view */
		public Controller Controller { get; set; }

		/** Model for this view */
		public object State { get; set; }
	}
}

