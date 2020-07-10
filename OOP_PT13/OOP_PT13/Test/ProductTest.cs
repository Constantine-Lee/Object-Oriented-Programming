using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	[TestFixture()]
	public class ProductTest
	{

		[Test()]
		public void ProductAddTest()
		{
			//To test we need to initialize categoryManagementModule and ProductManagementModule.
			CategoryManagementModule _categoryManagementModule = new CategoryManagementModule();
			Product product1 = new Product(2, "Myvi", 1, 4,  _categoryManagementModule.Category[0]);
			ProductManagementModule _productManagementModule = new ProductManagementModule(_categoryManagementModule);

			//Instantiate ProductManagementModule will auto instantiate one product inside it. 
			Assert.AreEqual(1, _productManagementModule.ProductCount);
			_productManagementModule.Add(product1);

			//The product count will be 2 by adding one product to it. 
			Assert.AreEqual(2, _productManagementModule.ProductCount);
		}

		[Test()]
		public void ProductEditTest()
		{
			//To test we need to initialize categoryManagementModule and ProductManagementModule.
			CategoryManagementModule _categoryManagementModule = new CategoryManagementModule();
			Product product1 = new Product(2, "Myvi", 1, 4, _categoryManagementModule.Category[0]);
			ProductManagementModule _productManagementModule = new ProductManagementModule(_categoryManagementModule);

			//Based on the passed parameter when initialize product1.
			Assert.AreEqual(4, product1.Price);
			_productManagementModule.EditPrice(product1, 10);

			//will be 10 after EditPrice function.
			Assert.AreEqual(10, product1.Price);
		}

		[Test()]
		public void ProductRemoveTest()
		{
			//To test we need to initialize categoryManagementModule and ProductManagementModule.
			CategoryManagementModule _categoryManagementModule = new CategoryManagementModule();
			Product product1 = new Product(2, "Myvi", 1, 4, _categoryManagementModule.Category[0]);
			ProductManagementModule _productManagementModule = new ProductManagementModule(_categoryManagementModule);


			_productManagementModule.Add(product1);

			//The product count will be 2 by adding one product to it. 
			Assert.AreEqual(2, _productManagementModule.ProductCount);
			_productManagementModule.Remove(product1);

			//The product count will be 1 after removing one product to it. 
			Assert.AreEqual(1, _productManagementModule.ProductCount);
		}
	}
}
