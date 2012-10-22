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

		[Test()]
		public void test_can_read_records ()
		{
			var instance = setup();

			var count = instance.Count();
			var note = instance.Create ("Hello", "World");
			var new_count = instance.Count();
			Assert.IsTrue(new_count == count + 1, "Unable to read count");

			var notes = instance.All(100, 0);
			count = notes.Count;
			Assert.IsTrue(new_count == count, "Unable to read all records");
		}

		[Test()]
		public void test_can_delete_records()
		{
			var instance = setup();

			instance.Create ("Hello", "World");
			instance.Create ("Hello", "World");
			instance.Create ("Hello", "World");
			instance.Create ("Hello", "World");
			instance.Create ("Hello", "World");
			instance.Create ("Hello", "World");

			var notes = instance.All(100, 0);
			foreach (var item in notes) {
				n.Infrastructure.nLog.Debug("Deleting record: " + item.Id);
				instance.Delete(item);
			}
			var count = instance.Count();
			Assert.AreEqual(0, count, "Invalid count after deleting records");
		}

		[Test()]
		public void test_can_update_record ()
		{
			var instance = setup();
			var note = instance.Create ("Hello", "World");
			note = instance.Get(note.Id);
			Assert.IsNotNull(note, "Unable to get note by id");

			note.Name = "Hello2";
			note.Value = "World2";
			instance.Save(note);
			note = instance.Get(note.Id);

			Assert.AreEqual(note.Name, "Hello2", "Unable to save note name");
			Assert.AreEqual(note.Value, "World2", "Unable to save note value");
		}
	}
}

