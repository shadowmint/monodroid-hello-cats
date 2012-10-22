using System;
using n.Infrastructure;
using System.Collections.Generic;

namespace n.Infrastructure.Impl
{
	public class nTestView : nView
	{
		public const string TARGET = "TARGET";

		public nTestView(nModel model, Type target) {
			Model = model;
			Action = new nAction() {
				Params = new Dictionary<string, object>() {
					{ TARGET, target },
				}
			};
		}
	}
}

