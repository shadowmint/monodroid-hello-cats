using System;
using n.Infrastructure;
using System.IO;

namespace n.Infrastructure.Impl
{
	public class nTestLogWriter : nLogWriter
	{
		public void Trace(string message) {
			using (StreamWriter w = File.AppendText("log.txt"))
			{
				w.WriteLine(message);
			}
		}
	}
}

