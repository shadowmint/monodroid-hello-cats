using System;
using System.Collections.Generic;

namespace Hello2.Infrastructure.MVC
{
	public class ActionResult
	{
		public ActionResult(string id, Object model) {
		}

		public object Model { get; set; }

		public string Path { get; set; }

		public IDictionary<string, Object> Params { get; set; }
	}
}

