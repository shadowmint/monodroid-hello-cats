using System;
using MVC.Infrastructure;

namespace HelloWorld.Model
{
	public class AppSession : ISession 
	{
		private static AppModel _instance = null;

		public override object State {
			get {
				if (_instance == null)
					_instance = new AppModel();
				return _instance;
			}
		}
	}
}

