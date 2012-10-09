using System;
using Hello2.Infrastructure.MVC;

namespace Hello2Tests.MVC.Mocks
{
	public class MockView2 : IView 
	{
		public static string ID = "mock.view2";

		public void SetModel (object model)
		{
		}
	}
}

