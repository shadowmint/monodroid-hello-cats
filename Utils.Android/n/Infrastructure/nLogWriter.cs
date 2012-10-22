using System;
using System.Data;
using Mono.Data.Sqlite;

namespace n.Infrastructure
{
	public interface nLogWriter
	{
		void Trace(string message);
	}
}

