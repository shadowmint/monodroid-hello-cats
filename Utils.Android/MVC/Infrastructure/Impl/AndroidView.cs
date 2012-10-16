using System;
using MVC.Infrastructure;
using Android.App;

namespace MVC.Infrastructure.Impl
{
	public abstract class AndroidView : Activity, IView
	{
		public ViewData ViewData { 
			get {
				return AndroidDispatcher.ViewData;
			}
		}
	}
}

