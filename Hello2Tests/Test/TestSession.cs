using System;
using MVC.Infrastructure;

namespace Utils.Raw.Tests
{
	public class TestSession : ISession
	{
		private TestAppState _instance = null;

		public override object State {
			get {
				if (_instance == null) 
					_instance = new TestAppState();
				return _instance;
			}
		}
	}
}

