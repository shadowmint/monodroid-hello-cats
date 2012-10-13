using System;
using NUnit.Framework;
using MVC.Infrastructure;

namespace Utils.Raw.Tests.MVC
{
	[TestFixture()]
	public class TestMvcWorks
	{
		private Resolver setup() {

			var r = new Resolver();
			r.Bind<IDispatcher, TestDispatcher>();
			r.Bind<ISession, TestSession>();

			TestDispatcher.Bind(TestView1.ID, new TestView1());
			TestDispatcher.Bind(TestView2.ID, new TestView2());

			return r;
		}

		[Test()]
		public void test_can_resolve_dispatcher()
		{
			var r = setup();
			var d = r.Resolve<IDispatcher>();
			Assert.IsNotNull(d, "Unable to bind and resolve the dispatcher");
		}

		[Test()]
		public void test_can_invoke_controller()
		{
			var r = setup();
			var controller = r.Resolve<TestController1>();
			Assert.IsNotNull(controller, "Unable to create controller instance");

			Assert.IsNull(TestDispatcher.CurrentView, "View was set before a reques to set the view");
			controller.JumpToOtherView();
			Assert.IsNotNull(TestDispatcher.CurrentView, "View was not set after a request to set the view");
		}
	}
}

