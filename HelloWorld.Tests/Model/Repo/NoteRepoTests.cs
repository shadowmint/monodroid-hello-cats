using System;
using NUnit.Framework;
using n.Infrastructure;
using n.Infrastructure.Impl;
using HelloWorld.Models.Repo;

namespace HelloWorld.Tests
{
	[TestFixture()]
	public class NoteRepoTests
	{
		private NoteRepo setup() {
			var r = new nResolver();
			nTestBindings.Bind(r);

			var db = r.Resolve<nDb>();
			var rtn = new NoteRepo(db);
			return rtn;
		}

		[Test()]
		public void test_can_create_instance ()
		{
			var instance = setup();
			Assert.NotNull(instance, "Unable to create instance");
		}

		[Test()]
		public void test_can_insert_record ()
		{
			var instance = setup();
			var note = instance.Create ("Hello", "World");

			Assert.IsTrue(note.Valid, "Unable to create instance of record: " + note.Errors.Summary);
			Assert.IsTrue(note.Id >= 0, "Unable to fetch id for new record");
		}
	}
}

