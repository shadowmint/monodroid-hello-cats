using System;

namespace Hello2
{
	public class HomeController
	{
		public HomeController()
		{
		}

		public string HelloWorld() {
			var model = new HelloWorldViewModel() {
				Message = "Hello There"
			};
			return "HelloWorld";
		}
	}
}

