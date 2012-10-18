using System;
using System.Data;
using System.Collections.Generic;
using n.Infrastructure.Dapper;

namespace n.Infrastructure
{
	public abstract class nDbRecord
	{
		public nDbRecord (nDb connectionFactory)
		{
			_db = connectionFactory.Connection;
		}

		/** If a copy of this record exists in the database */
		protected bool _persisted = false;

		/** Database connection for db methods to use */
		protected IDbConnection _db;

		/** Records should implement this to validate the record */
		public abstract bool Validate();

		/** Save this record, performing an insert if required, and update the key field */
		protected abstract bool SaveRecord();

		/** Delete this record if possible */
		protected abstract bool DeleteRecord();

		/** Set of errors associated with the object */
		public nDbRecordErrors Errors = new nDbRecordErrors();

		/** If there are any errors */
		public bool Valid { 
			get {
				return Errors.Any;
			} 
		}

		/** Save this record, performing an insert if required */
		public bool Save ()
		{
			Validate();
			var success = Valid;
			if (success) success = SaveRecord(); 
			if (success) _persisted = true;
			return success;
		}

		/** Delete this record, if it exists */
		public bool Delete ()
		{
			var success = false;
			if (_persisted) 
				success = DeleteRecord();
			return success;
		}
	}
}

