using System;
using Hello2.Infrastructure.MVC;

namespace Hello2Tests.MVC.Mocks
{
	public class MockView1 : IView 
	{
		public static string ID = "mock.view1";

		public void SetModel (object model)
		{
		}
	}
}

