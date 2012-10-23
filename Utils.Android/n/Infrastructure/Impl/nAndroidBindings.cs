using System;
using n.Infrastructure;
using System.Collections.Generic;
using Android.Content;

namespace n.Infrastructure.Impl
{
	public class nAndroidBindings
	{
		public static void Bind(nResolver resolver) {
			resolver.Bind<nDb, nAndroidDb>();
			resolver.Bind<nViewFactory, nAndroidViewFactory>();
			resolver.Bind<nDispatcher, nAndroidDispatcher>();
			resolver.Bind<nLogWriter, nAndroidLogWriter>();
		}
	}
}

