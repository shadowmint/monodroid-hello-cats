using System;
using System.Data;
using System.Collections.Generic;
using n.Infrastructure.Dapper;

namespace n.Infrastructure
{
	public abstract class nDbRecord
	{
		/** If a copy of this record exists in the database */
		public bool _persisted = false;

		/** Database connection for db methods to use */
		protected nDbRepo _repo;

		/** Records should implement this to validate the record */
		public abstract bool Validate();

		/** Set of errors associated with the object */
		public nDbRecordErrors Errors = new nDbRecordErrors();



		/** If there are any errors */
		public bool Valid { 
			get {
				return !Errors.Any;
			} 
		}
	}
}

