using System;
using NUnit.Framework;
namespace OOP_T1_P3
{
	[TestFixture()]
	public class ProjectTest
	{
		[Test()]
		public void ResouceAddOrRemoveTest()
		{
			Project project1 = new Project();
			Resources resource1 = new Resources("SIaw Zheng", true, ResourceCategory.Worker);
			project1.AddResource(resource1);
			Assert.AreEqual(1, project1.ResourcesCount);
			project1.RemoveResource(resource1);
			Assert.AreEqual(0, project1.ResourcesCount);
		}

		[Test()]
		public void ResouceStatusTest()
		{
			Project project1 = new Project();
			Resources resource1 = new Resources("1", true, ResourceCategory.Worker);
			Assert.IsFalse(project1.Status);
			project1.Status = true;
			Assert.IsTrue(project1.Status);
		}

		[Test()]
		public void ResouceFetchTest()
		{
			Project project1 = new Project();
			Resources resource1 = new Resources("1", true, ResourceCategory.Worker);
			project1.AddResource(resource1);
			Assert.IsTrue(project1[0].Status);
		}
	}
}
