using System;
using n.Infrastructure;

namespace n.Infrastructure.Impl
{
	public class nTestViewFactory : nViewFactory
	{
		public nView View (params object[] values)
		{
			nView rtn = null;
			var value = (int) values[0];
			var type = (nViewType) Enum.ToObject(typeof(nViewType), value);
			if (type == nViewType.ACTION_ONLY) 
				rtn = new nTestView(null, (Type) values[1]);
			else if (type == nViewType.MODEL_ONLY)
				rtn = new nTestView((nModel) values[1], null);
			else if (type == nViewType.MODEL_AND_ACTION)
				rtn = new nTestView((nModel) values[1], (Type) values[2]);
			 else 
				throw new Exception("Invalid view params");
			return rtn;
		}
	}
}

