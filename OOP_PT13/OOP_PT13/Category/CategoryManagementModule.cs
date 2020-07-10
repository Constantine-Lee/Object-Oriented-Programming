using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public class CategoryManagementModule:ManagementModule
	{
		/// <summary>
		/// The category.
		/// </summary>
		private List<Category> _category;

		/// <summary>
		/// Initializes a new instance of the CategoryManagementModule class.
		/// </summary>
		public CategoryManagementModule()
		{
			Category = new List<Category>() { new Category(2, "Car")};		
		}

		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		/// <value>The category.</value>
		public List<Category> Category
		{
			get{return _category;}
			set{_category = value;}
		}

		/// <summary>
		/// Gets the category count.
		/// </summary>
		/// <value>The category count.</value>
		public int CategoryCount
		{
			get { return _category.Count; }
		}

		/// <summary>
		/// Add category.
		/// </summary>
		public override void Add()
		{
			Console.WriteLine("Please enter the new id for category.");
			int id = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the new value for category type.");
			Category.Add(new Category(id, Console.ReadLine()));

			Console.WriteLine("Category added.");
			Console.ReadLine();
		}

		//Provide programmer a direct way to add category.
		public void Add(Category category)
		{
			_category.Add(category);
		}

		/// <summary>
		/// Edit category.
		/// </summary>
		public override void Edit()
		{
			Console.WriteLine("Category Editor.");
			Category category = SelectCategory();
			if (category != null)
			{
				Console.WriteLine("Please enter the new value for category type.");
				category.Type = Console.ReadLine();
				Console.WriteLine("Edit successful!");
				Console.ReadLine();
			}
		}

		/// <summary>
		/// Edit the specified category and type.
		/// </summary>
		/// <param name="category">Category.</param>
		/// <param name="type">Type.</param>
		public void Edit(Category category, string type)
		{
			category.Type = type;
		}

		/// <summary>
		/// Remove category.
		/// </summary>
		public override void Remove()
		{
			Console.WriteLine("Category Deletion.");
			Category category = SelectCategory();
			if (category != null)
			{
				Category.Remove(category);
				Console.WriteLine("Category Deleted.");
				Console.ReadLine();
			}
		}

		/// <summary>
		/// Remove the specified category.
		/// </summary>
		/// <param name="category">Category.</param>
		public void Remove(Category category)
		{
			_category.Remove(category);
		}

		/// <summary>
		/// Selects the category.
		/// </summary>
		/// <returns>The category.</returns>
		public Category SelectCategory()
		{
			for (int i = 1; i <= Category.Count; i++)
			{
				Console.WriteLine("{0} :{1}", i, Category[i - 1].Type);
			}

			Console.WriteLine("Choose the specific Category.");
			int CategoryID = int.Parse(Console.ReadLine());

			if (CategoryID <= Category.Count && 0 < CategoryID)
			{
				return Category[CategoryID - 1];
			}

			Console.WriteLine("Category not found!");
			Console.ReadLine();
			return null;
		}

	}
}
