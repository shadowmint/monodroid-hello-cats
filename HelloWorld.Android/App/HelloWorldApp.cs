using System;
using MVC.Infrastructure;
using MVC.Infrastructure.Impl;

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

