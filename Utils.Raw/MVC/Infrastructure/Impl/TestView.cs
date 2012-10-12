using System;
using MVC.Infrastructure;

namespace Utils
{
	public abstract class TestView : IView
	{
		public Controller _Controller 
		{ 
			get 
			{
				return TestDispatcher.Controller;
			}
		}

		public object _Model 
		{ 
			get 
			{ 
				return TestDispatcher.Model; 
			} 
		}
	}
}

