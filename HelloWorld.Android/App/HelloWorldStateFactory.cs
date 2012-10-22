using System;
using n.Infrastructure;
using HelloWorld.Model;
using System.Collections.Generic;
using HelloWorld.Controllers;
using HelloWorld.Views.Home;

namespace HelloWorld
{
	public class HelloWorldStateFactory : nStateFactory
	{
		private static HelloWorldState _instance;

		private IDictionary<string, Type> _viewMap = new Dictionary<string, Type>() {
			{ HomeController.INDEX, typeof(HelloView1) },
			{ NotesController.INDEX, typeof(NotesView) }
		};

		public object State { 
			get {
				if (_instance == null)
					_instance = new HelloWorldState();
				return _instance;
			}
		}

		public Type View(string id) {
			return _viewMap.ContainsKey(id) ? _viewMap[id] : null;
		}
	}
}

