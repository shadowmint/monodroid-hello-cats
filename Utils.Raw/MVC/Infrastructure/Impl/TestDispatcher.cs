using System;
using MVC.Infrastructure;

namespace Utils
{
	public class TestDispatcher : IDispatcher
	{
		public static object Model { get; set; }

		public static Controller Controller { get; set; }

		public void Dispatch (string id, Controller controller, object model)
		{
			Model = model;
			Controller = controller;
		}
	}
}

