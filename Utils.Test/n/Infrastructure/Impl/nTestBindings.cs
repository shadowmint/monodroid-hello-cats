using System;
using n.Infrastructure;
using System.Collections.Generic;

namespace n.Infrastructure.Impl
{
	public class nTestBindings
	{
		public static void Bind(nResolver resolver) {
			resolver.Bind<nDb, nTestDb>();
			resolver.Bind<nViewFactory, nTestViewFactory>();
			resolver.Bind<nDispatcher, nTestDispatcher>();
			resolver.Bind<nLogWriter, nTestLogWriter>();
		}
	}
}

