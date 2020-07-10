using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace OOP_T1_P3
{
	[TestFixture ()]
	public class ResourceCategoryTest
	{	

		[Test()]
		public void TestResource()
		{
			Resources[] arrayResources = new Resources[4];
			arrayResources[0] = new Worker("1", true, 1, 2);
			arrayResources[1] = new Document("1", true, "OOP");
			arrayResources[2] = new Vehicle("1", true);
			arrayResources[3] = new Product("1", true);
			Assert.AreEqual(arrayResources[0].Deploy(), "Total Salary: 2");
			Assert.AreEqual(arrayResources[1].Deploy(), "OOP");
			Assert.AreEqual(arrayResources[2].Deploy(), "Lorry/truck deployed!");
			Assert.AreEqual(arrayResources[3].Deploy(), "Deployed success");
		}

		[Test()]
		public void TestStatus()
		{
			Resources[] arrayResources = new Resources[1];
			arrayResources[0] = new Worker("1", true, 1, 2);
			Assert.IsTrue(arrayResources[0].Status);
			arrayResources[0].Status = false;
			Assert.IsFalse(arrayResources[0].Status);
		}


	}
}
