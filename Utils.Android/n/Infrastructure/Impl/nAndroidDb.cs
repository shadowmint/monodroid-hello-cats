using System;
using n.Infrastructure;
using Android.App;
using Android.Content;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Mono.Data.Sqlite;

namespace n.Infrastructure.Impl
{
	public class nAndroidDb : nDb
	{
		public IDbConnection Connection {
			get {
				string dbPath = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.Personal), "data.sqlite");
				bool exists = File.Exists (dbPath);
				if (!exists)
					SqliteConnection.CreateFile (dbPath);
				var connection = new SqliteConnection ("Data Source=" + dbPath);
				connection.Open ();
				return connection;
			}
		}
	}
}

