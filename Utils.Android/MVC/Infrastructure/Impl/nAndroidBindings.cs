using System;
using MVC.Infrastructure;
using System.Collections.Generic;
using Android.Content;

namespace MVC.Infrastructure.Impl
{
	public class nAndroidBindings
	{
		public static void Bind(nResolver resolver) {
			resolver.Bind<nViewFactory, nAndroidViewFactory>();
			resolver.Bind<nDispatcher, nAndroidDispatcher>();
		}
	}
}

