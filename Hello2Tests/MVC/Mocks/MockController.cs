using System;
using Hello2.Infrastructure.MVC;

namespace Hello2Tests.MVC.Mocks
{
	public class MockController : IController 
	{
		public ActionResult Hello1 ()
		{
			var model = new MockViewModel() {
				Name = "View1",
				Value = "Hello World"
			};
			return new ActionResult(MockView1.ID, model);
		}

		public ActionResult Hello2 ()
		{
			var model = new MockViewModel() {
				Name = "View2",
				Value = "Hello World"
			};
			return new ActionResult(MockView2.ID, model);
		}

		public IControllerAction Navigate (string[] path)
		{
			return Hello1;
		}
	}
}

