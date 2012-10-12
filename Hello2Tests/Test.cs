using System;
using NUnit.Framework;

namespace Hello2Tests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void test_can_run_tests()
		{
			Assert.True(true);
		}
	}
}

