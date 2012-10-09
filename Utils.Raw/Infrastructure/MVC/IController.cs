using System;

namespace Hello2.Infrastructure.MVC
{
	public delegate ActionResult IControllerAction();

	public interface IController
	{
		IControllerAction Navigate(string[] path);

		Object Context { get; set; }
	}
}

