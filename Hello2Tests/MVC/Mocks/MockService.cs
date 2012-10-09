using System;
using Hello2.Infrastructure.MVC;

namespace Hello2Tests.MVC.Mocks
{
	public class MockService : IMockService 
	{
		public string getStringValue() {
			return "Hello World";
		}
	}
}

