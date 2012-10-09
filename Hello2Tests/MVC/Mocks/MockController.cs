using System;
using Hello2.Infrastructure.MVC;

namespace Hello2Tests.MVC.Mocks
{
	public class MockController : IController 
	{
		private MockContext _mc;

		public Object Context 
		{
			get 
			{
				return _mc;
			}
			set 
			{
				_mc = (MockContext) value;
			}
		}

		public IControllerAction Navigate (string[] path)
		{
			throw new NotImplementedException ();
		}

		public ActionResult Hello1 ()
		{
			var model = new MockViewModel() {
				Name = "View1",
				Value = "Hello World"
			};
			return new ActionResult(MockView1.ID, model, Context);
		}

		public ActionResult Hello2 ()
		{
			var model = new MockViewModel() {
				Name = "View2",
				Value = "Hello World"
			};
			return new ActionResult(MockView2.ID, model, Context);
		}
	}
}

