using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public class ProductManagementModule: ManagementModule
	{
		/// <summary>
		/// List of product.
		/// </summary>
		private List<Product> _product;

		/// <summary>
		/// The category management module.
		/// </summary>
		private CategoryManagementModule _categoryManagementModule;

		public ProductManagementModule(CategoryManagementModule categoryManagementModule)
		{
			/// <summary>
			/// Initialize one product for debug purpose.
			/// </summary>
			_product = new List<Product>() { new Product(1, "Perodua", 2, 4, categoryManagementModule.Category[0]) };
			_categoryManagementModule = categoryManagementModule;
		}

		/// <summary>
		/// Gets the product count.
		/// </summary>
		public int ProductCount
		{
			get{return _product.Count;}
		}

		/// <summary>
		/// Add product.
		/// </summary>
		public override void Add()
		{
			Console.WriteLine("\nAdd Product Panel.");
			_product.Add(AskProductSpecification());
			AnnounceOperationSuccess();
		}

		/// <summary>
		/// Directly add the product from parameter.
		/// </summary>
		public void Add(Product product)
		{
			_product.Add(product);
		}

		/// <summary>
		/// Edit product.
		/// </summary>
		public override void Edit()
		{
			Product product = SelectProduct();
			string detailSelection = SelectDetail();
			Console.WriteLine("Please type the new value.");

			switch (detailSelection)
			{
				
				case "1":
					product.Name = Console.ReadLine();
					AnnounceOperationSuccess();
					break;
				case "2":
					product.Quantity = int.Parse(Console.ReadLine());
					AnnounceOperationSuccess();
					break;
				case "3":
					product.Price = int.Parse(Console.ReadLine());
					AnnounceOperationSuccess();
					break;
				case "4":
					product.Category.Type = Console.ReadLine();
					AnnounceOperationSuccess();
					break;
				case "5":
					product.Description = Console.ReadLine();
					AnnounceOperationSuccess();
					break;
				default:
					break;
			}
		}

		//Provide a simply way for programmer to directly change price.
		public void EditPrice(Product product, int price)
		{
			product.Price = price;
		}

		/// <summary>
		/// Remove product.
		/// </summary>
		public override void Remove()
		{
			Console.WriteLine("\nProduct Deletion Panel.");
			Product product = SelectProduct();
			_product.Remove(product);
			AnnounceOperationSuccess();
		}

		//Provide a simply way for programmer to directly remove product.
		public void Remove(Product product)
		{
			_product.Remove(product);
		}

		/// <summary>
		/// Selects the product.
		/// </summary>
		/// <returns>The product.</returns>
		private Product SelectProduct()
		{
			
			for (int i = 1; i <= _product.Count; i++)
			{
				Console.WriteLine(" {0} : {1}", i, _product[i - 1].Name);
			}
			Console.WriteLine("Choose the specific product.");
			return _product[int.Parse(Console.ReadLine()) - 1];
		}

		/// <summary>
		/// Selects the detail.
		/// </summary>
		/// <returns>The detail.</returns>
		private string SelectDetail()
		{
			Console.WriteLine("Which detail you want to edit?");
			Console.WriteLine("1:Name\n2:Quantity\n3:Price\n4:Category\n5:Description");
			return Console.ReadLine();
		}

		/// <summary>
		/// Announces the operation success.
		/// </summary>
		private void AnnounceOperationSuccess()
		{
			Console.WriteLine("Operation success!");
			Console.ReadLine();
		}

		/// <summary>
		/// Asks the product specification and create product according to it.
		/// </summary>
		private Product AskProductSpecification()
		{

			Console.WriteLine("Please enter the new id for product.");
			int id = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the new name for product.");
			string name = Console.ReadLine();

			Console.WriteLine("Please enter the new quantity for product.");
			int quantity = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the price for product.");
			int price = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the category for product.");
			Category category = _categoryManagementModule.SelectCategory();

			return new Product(id, name, quantity, price, category);
		}
	}
}
