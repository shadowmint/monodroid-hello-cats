using System;

namespace Utils.Raw.Tests
{
	public class TestAppState
	{
		public static string Value = "";

		public string LocalValue {
			set {
				Value = value;
			}
		}

	}
}

