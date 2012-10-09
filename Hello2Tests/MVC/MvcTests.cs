using System;
using NUnit.Framework;
using Hello2Tests.MVC.Mocks;

namespace Hello2Tests.MVC
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void test_can_create_app()
		{
			var app = new MockApp();
			Assert.IsNotNull (app);
		}
	}
}

