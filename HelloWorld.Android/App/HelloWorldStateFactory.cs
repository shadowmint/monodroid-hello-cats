using System;
using MVC.Infrastructure;
using HelloWorld.Model;

namespace HelloWorld
{
	public class HelloWorldStateFactory : nStateFactory
	{
		private static HelloWorldState _instance;

		public object State { 
			get {
				if (_instance == null)
					_instance = new HelloWorldState();
				return _instance;
			}
		}
	}
}

