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
			if (values.Length == 2) {
				if (values[0].GetType == typeof(Type)) {
					rtn = new nAndroidView(null, (Type) values[0], (Context) values[1]);
				}
				else {
					rtn = new nAndroidView(values[0], null, (Context) values[1]);
				}
			} else if (values.Length == 3) {
				rtn = new nAndroidView(values[0], (Type) values[1], (Context) values[2]);
			} else {
				throw new Exception("Invalid view params");
			}
			return rtn;
		}
	}
}

