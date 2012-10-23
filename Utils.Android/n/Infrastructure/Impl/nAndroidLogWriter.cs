using System;
using System.Data;
using Mono.Data.Sqlite;

namespace n.Infrastructure.Impl
{
	public class nAndroidLogWriter : nLogWriter
	{
		public void Trace(string message) {
			Android.Util.Log.Debug("nDB", message);
		}
	}
}

