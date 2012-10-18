using System;
using n.Infrastructure;
using n.Infrastructure.Impl;

namespace HelloWorld
{
	public class HelloWorldApp : nApp
	{
		protected override void setup (nResolver resolver)
		{
			nAndroidBindings.Bind(resolver);
			resolver.Bind<nStateFactory, HelloWorldStateFactory>();
		}
	}
}

