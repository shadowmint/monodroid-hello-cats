using System;
using MVC.Infrastructure;

namespace MVC.Infrastructure.Impl
{
	public abstract class AndroidView : View
	{
		protected override ViewData ViewData { 
			get {
				return AndroidDispatcher.ViewData;
			}
		}
	}
}

