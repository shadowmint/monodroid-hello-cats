using System;

namespace Hello2.Infrastructure.MVC
{
	public class Route
	{
		public string Path { get; set; }

		public IController Controller { get; set; }

		public IControllerAction Action { get; set; }
	}
}

