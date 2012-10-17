using System;
using MVC.Infrastructure;
using System.Collections.Generic;
using Android.Content;

namespace MVC.Infrastructure.Impl
{
	public class nAndroidDispatcher : nDispatcher
	{
		public void Dispatch (nView view)
		{
			Context context = (Context) view.Action.Params[nAndroidView.CONTEXT];
			Type target = (Type) view.Action.Params[nAndroidView.TARGET];
			var intent = new Intent(context, target);
			context.StartActivity(intent);
		}
	}
}

