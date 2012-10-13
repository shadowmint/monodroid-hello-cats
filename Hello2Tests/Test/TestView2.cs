using System;
using MVC.Infrastructure;

namespace Utils.Raw.Tests
{
	public class TestView2 : TestView
	{
		public const string ID = "VIEW2";

		protected TestController2 Controller { 
			get {
				return (TestController2)ViewData.Controller;
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

