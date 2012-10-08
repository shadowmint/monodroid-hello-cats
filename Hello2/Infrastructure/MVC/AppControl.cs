using System;

namespace Hello2.Infrastructure.MVC
{
	public class AppControl
	{
		public Controllers C { get; private set; }

		protected AppControl ()
		{
			C = new Controllers();
		}
	}
}

