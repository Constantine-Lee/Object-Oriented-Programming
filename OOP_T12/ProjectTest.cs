using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace OOP_T1_P3
{
	[TestFixture()]
	public class ProjectTest
	{
		[Test()]
		public void ResouceAddOrRemoveTest()
		{
			Project fetchProject = new Project();
			Resources[] resourceArray = new Resources[4];
			resourceArray[0] = new Worker("1", true, 1, 2);
			resourceArray[1] = new Document("1", true, "OOP");
			resourceArray[2] = new Vehicle("1", true);
			resourceArray[3] = new Product("1", true);

			for (int x = 0; x < 4; x++)
			{
				fetchProject.AddResource(resourceArray[x]);
			}

			Assert.AreEqual(4, fetchProject.ResourcesCount);

			for (int x = 0; x < 4; x++)
			{
				fetchProject.RemoveResource(resourceArray[x]);
			}
			Assert.AreEqual(0, fetchProject.ResourcesCount);
		}

		[Test()]
		public void ResouceFetchTest()
		{
			Project fetchProject = new Project();
			Resources[] resourceArray = new Resources[4];
			resourceArray[0] = new Worker("1", true, 1, 2);
			resourceArray[1] = new Document("1", true, "OOP");
			resourceArray[2] = new Vehicle("1", true);
			resourceArray[3] = new Product("1", true);

			for (int x = 0; x < 4; x++)
			{
				fetchProject.AddResource(resourceArray[x]);
			}

			Assert.IsTrue(fetchProject[0].Status);
			Assert.IsTrue(fetchProject[1].Status);
			Assert.IsTrue(fetchProject[2].Status);
			Assert.IsTrue(fetchProject[3].Status);


		}




	}
}
