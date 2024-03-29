using System;

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

		public Note() {
			Id = -1;
		}

		public override bool Validate ()
		{
			if ((Name == null) || (Name == "")) Errors.Add("Name", "Invalid name: must not be empty or null");
			if ((Value == null) || (Value == "")) Errors.Add("Value", "Invalid value: must not be empty or null");
			return !Errors.Any;
		}
	}
}


