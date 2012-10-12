using System;
using MVC.Infrastructure;

namespace Utils.Raw.Tests
{
	public class TestController : Controller 
	{
		private TestAppState State { get { return (TestAppState) _session._State; } }

		public TestController (ISession session, IDispatcher dispatcher, Resolver resolver) : base(session, dispatcher, resolver)
		{
		}
	}
}

