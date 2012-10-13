using System;
using MVC.Infrastructure;

namespace Utils.Raw.Tests
{
	public class TestView1 : TestView
	{
		public const string ID = "VIEW1";

		protected TestController1 Controller { 
			get {
				return (TestController1)ViewData.Controller;
			}
		}

		protected TestViewModel State {
			get {
				return (TestViewModel)ViewData.State;
			}
		}

		public void FakeUserClickSet(bool stateIsSet)
		{
			if (stateIsSet) 
				Controller.SetValue(State.Value);
			else 
				Controller.SetValue("");
		}

		public void FakeUserClickNav() {
			Controller.JumpToOtherView();
		}
	}
}

