using System;
using Hello2.Infrastructure.MVC;

namespace Hello2Tests.MVC.Mocks
{
	public class MockAppSetup : IAppSetup 
	{
		public void SetupDependencies()
		{
			AppControlFactory.Register<IMockService>(new MockService());
		}

		public void SetupControllers (AppControl app)
		{
			app.Attach(AppControlFactory.Resolve<MockController>(), "app.home.{0}");
		}
	}
}

