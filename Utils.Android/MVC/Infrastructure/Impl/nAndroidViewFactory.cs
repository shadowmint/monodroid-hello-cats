using System;
using MVC.Infrastructure;
using Android.App;
using Android.Content;

namespace MVC.Infrastructure.Impl
{
	public class nAndroidViewFactory : nViewFactory
	{
		public nView View (params object[] values)
		{
			nView rtn = null;
			var value = (int) values[0];
			var type = (nViewType) Enum.ToObject(typeof(nViewType), value);
			if (type == nViewType.ACTION_ONLY) 
				rtn = new nAndroidView(null, (Type) values[1], (Context) values[2]);
			else if (type == nViewType.MODEL_ONLY)
				rtn = new nAndroidView(values[1], null, (Context) values[2]);
			else if (type == nViewType.MODEL_AND_ACTION)
				rtn = new nAndroidView(values[1], (Type) values[2], (Context) values[3]);
			 else 
				throw new Exception("Invalid view params");
			return rtn;
		}
	}
}

