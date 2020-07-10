using System;
using NUnit.Framework;

namespace OOP_T1_P3
{
	[TestFixture()]
	public class ResourceCategoryTest
	{

		[Test()]
		public void TestResourceCategory()
		{
			Resources[] arrayResources = new Resources[4];
			arrayResources[0] = new Resources("W600", true, ResourceCategory.Worker);
			arrayResources[1] = new Resources("D700", false, ResourceCategory.Document);
			arrayResources[2] = new Resources("V800", true, ResourceCategory.Vehicle);
			arrayResources[3] = new Resources("A123", true, ResourceCategory.Product);
			Assert.AreEqual(arrayResources[0].deploy(), "Be alert on the hours worked!");
			Assert.AreEqual(arrayResources[1].deploy(), "Resource failed to deploy.");
			Assert.AreEqual(arrayResources[2].deploy(), "Lorry/truck deployed!");
			Assert.AreEqual(arrayResources[3].deploy(), "Check the availability before deploy!");
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
