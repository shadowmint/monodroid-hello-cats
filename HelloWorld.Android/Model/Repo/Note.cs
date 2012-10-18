using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using n.Infrastructure;
using n.Infrastructure.Dapper;
using System.Linq;

namespace HelloWorld.Models.Repo
{
	public class Note : nDbRecord
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Value { get; set; }

		public Note(nDb db) : base(db) {
		}

		public override bool Validate ()
		{
			if ((Name == null) || (Name == "")) Errors.Add("Name", "Invalid name: must not be empty or null");
			if ((Value == null) || (Value == "")) Errors.Add("Value", "Invalid name: must not be empty or null");
			return !Errors.Any;
		}

		protected override bool SaveRecord ()
		{
			var rtn = false;
			try {
				var query = string.Format ("INSERT INTO {0} (Name, Value) VALUE (@Name, @Value); SELECT last_insert_rowid()", NoteRepo.TABLE, Name, Value);
				Id = _db.Query<int> (query, new { Name = Name, Value = Value }).Single();
				rtn = true;
			} catch (Exception e) {
				Errors.Add("", "Unable to save record", e);
			}
			return rtn;
		}
		
		protected override bool DeleteRecord ()
		{
			var rtn = false;
			try {
				var query = string.Format ("DELETE FROM {0} WHERE Id = @Id", NoteRepo.TABLE);
				_db.Execute (query, new { Id = Id });
				rtn = true;
			} catch (Exception e) {
				Errors.Add("", "Unable to delete record", e);
			}
			return rtn;
		}
	}
}


