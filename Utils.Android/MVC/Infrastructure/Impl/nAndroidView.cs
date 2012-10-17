using System;
using MVC.Infrastructure;
using Android.App;
using Android.Content;

namespace MVC.Infrastructure.Impl
{
	public class nAndroidView : nView
	{
		public const string TARGET = "TARGET";

		public const string CONTEXT = "CONTEXT";

		public nAndroidView(object model, Type target, Context context) {
			Model = model;
			Action = new nAction() {
				{ TARGET, target },
				{ CONTEXT, context }
			};
		}
	}
}

