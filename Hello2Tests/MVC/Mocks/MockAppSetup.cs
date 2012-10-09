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
			var c = (MockController) app.Controller(typeof(MockController));
			app.Route(c, c.Hello1, MockView1.ID);
			app.Route(c, c.Hello2, MockView2.ID);
		}
	}
}

