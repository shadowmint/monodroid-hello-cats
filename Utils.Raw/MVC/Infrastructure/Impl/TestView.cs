using System;
using MVC.Infrastructure;

namespace Utils
{
	public abstract class TestView : View
	{
		protected override ViewData ViewData { 
			get {
				return TestDispatcher.ViewData;
			}
		}
	}
}

