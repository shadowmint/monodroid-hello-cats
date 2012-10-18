using System;
using System.Data;
using System.Collections.Generic;
using n.Infrastructure.Dapper;
using System.Linq;

namespace n.Infrastructure
{
	public abstract class nDbRepo
	{
		protected nDb _db;

		public nDbRepo (nDb connectionFactory)
		{
			_db = connectionFactory;
		}

		protected IEnumerable<T> Query<T>(string query, object bindings)
		{
			IDbConnection db = _db.Connection;
			var rtn = db.Query<T>(query, bindings);
			return rtn;
		}

		protected IEnumerable<T> All<T>(string table, int limit, int offset) {
			var query = string.Format (@"SELECT * FROM {0} LIMIT {1} OFFSET {2}", table, limit, offset);
			var rtn = (IEnumerable<T>) _db.Connection.Query<T>(query);
			return rtn;
		}

		protected T Get<T>(string table, string key, int id) {
			var query = string.Format (@"SELECT * FROM {0} WHERE {1} = @Id LIMIT 1", table, key);
			var rtn = _db.Connection.Query<T>(query, new { Id = id });
			return rtn.FirstOrDefault();
		}
	}
}

