using System;
using System.Collections.Generic;
using System.Linq;

namespace n.Infrastructure
{
	public abstract class nDbRepo
	{
		protected nDb _db;

		public nDbRepo (nDb connectionFactory)
		{
			_db = connectionFactory;
			Setup();
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

		/** Return a count of records */
		protected int Count(string table) {
			var query = string.Format (@"SELECT COUNT(*) FROM {0}", table);
			var rtn = _db.Connection.Query<int>(query).Single();
			return rtn;
		}

		/** Save this record, performing an insert if required */
		public bool Save(nDbRecord instance)
		{
			instance.Validate();
			var success = instance.Valid;
			if (success) success = SaveInstance(instance);
			if (success) instance._persisted = true;
			return success;
		}

		/** Delete this record, if it exists */
		public bool Delete (nDbRecord instance)
		{
			var success = false;
			if (instance._persisted) 
				success = DeleteInstance(instance);
			return success;
		}

		/** Should be implemented to save instances of the given type */
		protected abstract bool SaveInstance(nDbRecord instance);

		/** Should be implemented to delete instances of the given type */
		protected abstract bool DeleteInstance(nDbRecord instance);

		/** Create the table if it does not exist */
		protected abstract bool Setup();
	}
}

