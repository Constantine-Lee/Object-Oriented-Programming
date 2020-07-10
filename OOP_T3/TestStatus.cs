using System;
using NUnit.Framework;

namespace OOP_T1_P3
{
	[TestFixture()]
	public class TestStatus
	{
		public TestStatus()
		{
		}

		[Test()]
		public void Test()
		{
			Resources[] arrayResources = new Resources[1];
			arrayResources[0] = new Resources("W600", true, ResourceCategory.Worker);

			Assert.IsTrue(arrayResources[0].Status);

			arrayResources[0].Status = false;

			Assert.IsFalse(arrayResources[0].Status);

		}

	}
}
