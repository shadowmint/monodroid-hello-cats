using System;
using MVC.Infrastructure;

namespace Utils
{
	public abstract class TestView : IView
	{
		public ViewData ViewData { 
			get {
				return TestDispatcher.ViewData;
			}
		}
	}
}

