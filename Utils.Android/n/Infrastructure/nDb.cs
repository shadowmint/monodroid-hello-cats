using System;
using System.Data;
using Mono.Data.Sqlite;

namespace Utils.Dapper.Android
{
	public interface nDb
	{
		IDbConnection Connection();
	}
}

