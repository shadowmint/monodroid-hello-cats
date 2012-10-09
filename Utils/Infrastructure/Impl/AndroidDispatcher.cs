using System;
using Android.Content;
using Hello2.Infrastructure.MVC;
using Android.App;

namespace Utils
{
	public class AndroidDispatcher
	{
		public void Dispatch(object context, ActionResult action) {
			var activity = (Activity) context;
			Intent i = new Intent();
			i.SetClass(activity, action.View);
			activity.StartActivity(i);
		}
	}
}

