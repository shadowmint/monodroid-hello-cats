using System;
using Hello2.Infrastructure.MVC;

namespace Hello2Tests.MVC.Mocks
{
	public class MockView2 : IView 
	{
		public static string ID = "mock.view2";
		
		private MockViewModel _model;
		
		public MockView2 ()
		{
			GetViewModel();
		}
		
		public void GetViewModel ()
		{
			_model = MockApp.mvc.ViewModel<MockViewModel>(new MockContext() { Value = "View2" });
		}

		public string Action ()
		{
			return _model.Name + " == " + _model.Value;
		}
	}
}

