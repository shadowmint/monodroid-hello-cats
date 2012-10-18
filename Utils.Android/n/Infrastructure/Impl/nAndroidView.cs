using System;
using n.Infrastructure;
using Android.App;
using Android.Content;
using System.Collections.Generic;

namespace n.Infrastructure.Impl
{
	public class nAndroidView : nView
	{
		public const string TARGET = "TARGET";

		public const string CONTEXT = "CONTEXT";

		public nAndroidView(object model, Type target, Context context) {
			Model = model;
			Action = new nAction() {
				Params = new Dictionary<string, object>() {
					{ TARGET, target },
					{ CONTEXT, context }
				}
			};
		}
	}
}

