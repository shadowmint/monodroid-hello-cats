using System;
using Hello2.Infrastructure.MVC;

namespace Hello2
{
	public class HomeController : IController
	{
		public HomeController()
		{
		}

		public string HelloWorld() {
			return "HelloWorld";
		}

		public string Navigate(string[] path) {
			return "";
		}
	}
}

