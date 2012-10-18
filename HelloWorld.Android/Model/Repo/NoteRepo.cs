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

namespace HelloWorld.Models.Repo
{
	public class NoteRepo : nDbRepo
	{
		public const string TABLE = "hwNote";

		public const string ID = "Id";

		public const string CREATE_TABLE = "";

		public NoteRepo (nDb db) : base(db)
		{
		}

		public int Count() 
		{
			return 0;
		}

		public IEnumerable<Note> Query (string sql, object bindings)
		{
			return Query<Note>(sql, bindings);
		}

		public IEnumerable<Note> All(int limit, int offset) {
			return All<Note>(TABLE, limit, offset);
		}

		public Note Create (string name, string value) {
			var rtn = new Note(_db);
			rtn.Name = name;
			rtn.Value = value;
			rtn.Save();
			return rtn;
		}

		public Note Get(int id) {
			return Get<Note>(TABLE, ID, id);
		}
	}
}
