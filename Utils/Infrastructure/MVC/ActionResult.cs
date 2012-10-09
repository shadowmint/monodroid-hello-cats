using System;
using System.Collections.Generic;

namespace Hello2.Infrastructure.MVC
{
	public class ActionResult
	{
		public ActionResult(string id, Object model, Object context) {
		}

		public object Model { get; set; }

		public string Path { get; set; }

		public Type View { get; set; }
	}
}

