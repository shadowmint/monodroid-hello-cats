using System;
using Hello2.Infrastructure.MVC;

namespace Hello2Tests.MVC.Mocks
{
	public class MockView1 : IView 
	{
		public static string ID = "mock.view1";

		private MockViewModel _model;

		public MockView1 ()
		{
			GetViewModel();
		}

		public void GetViewModel ()
		{
			_model = MockApp.mvc.ViewModel<MockViewModel>(new MockContext() { Value = "View1" });
		}

		public string Action ()
		{
			return _model.Name + " = " + _model.Value;
		}
	}
}

