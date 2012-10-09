using System;
using Hello2.Infrastructure.MVC;

namespace Hello2Tests.MVC.Mocks
{
	public class MockApp
	{
		public static AppControl mvc = null;

		public void OnCreate()
		{
			if (mvc == null) {
				AppControlFactory.Register<IAppSetup>(new MockAppSetup());
				mvc = AppControlFactory.Resolve<AppControl>();
			}
		}
	}
}

