using System;
using NUnit.Framework;

namespace OOP_PT13_3
{
	[TestFixture()]
	public class CategoryTest
	{
		[Test()]
		public void CategoryAddTest()
		{
			
			CategoryManagementModule _categoryManagementModule = new CategoryManagementModule();
			Category category1 = new Category(7, "Electronic");

			//Instantiate CategoryManagementModule will auto instantiate one category inside it. 
			Assert.AreEqual(1, _categoryManagementModule.CategoryCount);
			_categoryManagementModule.Add(category1);

			//The category count will be 2 by adding one category to it. 
			Assert.AreEqual(2, _categoryManagementModule.CategoryCount);
		}

		[Test()]
		public void CategoryEditTest()
		{
			CategoryManagementModule _categoryManagementModule = new CategoryManagementModule();
			Category category1 = new Category(7, "Electronic");

			//Based on the passed parameter when initialize category1.
			Assert.AreEqual("Electronic", category1.Type);

			//will be "Robot" after Edit function.
			_categoryManagementModule.Edit(category1, "Robot");
			Assert.AreEqual("Robot", category1.Type);
		}

		[Test()]
		public void CategoryRemoveTest()
		{
			CategoryManagementModule _categoryManagementModule = new CategoryManagementModule();
			Category category1 = new Category(7, "Electronic");

			_categoryManagementModule.Add(category1);

			//The category count will be 2 by adding one category to it. 
			Assert.AreEqual(2, _categoryManagementModule.CategoryCount);
			_categoryManagementModule.Remove(category1);

			//The category count will be 1 by adding one category to it. 
			Assert.AreEqual(1, _categoryManagementModule.CategoryCount);
		}
	}
}
