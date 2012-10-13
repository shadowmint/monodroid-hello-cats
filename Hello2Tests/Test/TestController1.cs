using System;
using MVC.Infrastructure;

namespace Utils.Raw.Tests
{
	public class TestController1 : Controller
	{
		private TestAppState State { get { return (TestAppState) Session.State; } }

		public TestController1(ISession session, IDispatcher dispatcher) : base(session, dispatcher)
		{
		}

		public void SetValue(string value) {
			State.LocalValue = value;
		}

		public void JumpToOtherView() {
			Navigate<TestController2>(TestView2.ID, new TestViewModel() { Value = "Hello" });
		}
	}
}

