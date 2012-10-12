using System;
using MVC.Infrastructure;

namespace Utils.Raw.Tests
{
	public class TestView1 : TestView 
	{
		private TestController Controller
		{ 
			get 
			{
				return (TestController) _Controller;
			}
		}

		private TestViewModel1 Model {
			get {
				return (TestViewModel1)_Model;
			}
		}
	}
}

