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
	public class NoteRepo : nDbRepo
	{
		public const string TABLE = "hwNote";

		public const string ID = "Id";

		public const string CREATE_TABLE = "CREATE TABLE IF NOT EXISTS hwNote (Id INTEGER PRIMARY KEY, Name VARCHAR(50), Value VARCHAR(50))";

		public NoteRepo (nDb db) : base(db)
		{
		}

		protected override bool Setup() {
			_db.Connection.Execute(CREATE_TABLE);
			return true;
		}

		public int Count() 
		{
			return Count(TABLE);
		}

		public IEnumerable<Note> Query (string sql, object bindings)
		{
			return Query<Note>(sql, bindings);
		}

		public IEnumerable<Note> All(int limit, int offset) {
			return All<Note>(TABLE, limit, offset);
		}

		public Note Create (string name, string value) {
			var rtn = new Note();
			rtn.Name = name;
			rtn.Value = value;
			Save (rtn);
			return rtn;
		}

		public Note Get(int id) {
			return Get<Note>(TABLE, ID, id);
		}

		protected override bool SaveInstance(nDbRecord instance)
		{
			var item = (Note) instance;
			var rtn = false;
			try {
				var query = string.Format ("INSERT INTO {0} (Name, Value) VALUE (@Name, @Value); SELECT last_insert_rowid()", NoteRepo.TABLE, item.Name, item.Value);
				item.Id = _db.Connection.Query<int> (query, new { Name = item.Name, Value = item.Value }).Single();
				rtn = true;
			} catch (Exception e) {
				item.Errors.Add("", "Unable to save record", e);
			}
			return rtn;
		}
		
		protected override bool DeleteInstance(nDbRecord instance)
		{
			var item = (Note) instance;
			var rtn = false;
			try {
				var query = string.Format ("DELETE FROM {0} WHERE Id = @Id", NoteRepo.TABLE);
				_db.Connection.Execute (query, new { Id = item.Id });
				rtn = true;
			} catch (Exception e) {
				item.Errors.Add("", "Unable to delete record", e);
			}
			return rtn;
		}
	}
}
