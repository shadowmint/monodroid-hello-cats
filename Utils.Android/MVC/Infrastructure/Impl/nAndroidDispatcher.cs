using System;
using MVC.Infrastructure;
using System.Collections.Generic;
using Android.Content;
using Android.App;

namespace MVC.Infrastructure.Impl
{
	public class nAndroidDispatcher : nDispatcher
	{
		public void Dispatch (nView view)
		{
			Activity context = (Activity) view.Action.Params[nAndroidView.CONTEXT];
			Type target = (Type) view.Action.Params[nAndroidView.TARGET];
			var intent = new Intent(context, target);
			context.StartActivity(intent);
		}
	}
}

