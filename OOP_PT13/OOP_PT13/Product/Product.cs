using System;
namespace OOP_PT13_3
{
	public class Product: EntityID
	{
		/// <summary>
		/// The name.
		/// </summary>
		private string _name;

		/// <summary>
		/// The quantity.
		/// </summary>
		private int _quantity;

		/// <summary>
		/// The price.
		/// </summary>
		private int _price;

		/// <summary>
		/// The category.
		/// </summary>
		private Category _category;

		/// <summary>
		/// The description.
		/// </summary>
		private string _description;

		/// <summary>
		/// Initializes a new instance of the Product class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="name">Name.</param>
		/// <param name="quantity">Quantity.</param>
		/// <param name="price">Price.</param>
		/// <param name="category">Category.</param>
		public Product(int id, string name, int quantity, int price, Category category): base(id)
		{
			_name = name;
			_quantity = quantity;
			_category = category;
			_price = price;
		}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get{return _name;}
			set{_name = value;}
		}

		/// <summary>
		/// Gets or sets the quantity.
		/// </summary>
		/// <value>The quantity.</value>
		public int Quantity
		{
			get{return _quantity;}
			set{_quantity = value;}
		}

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		/// <value>The price.</value>
		public int Price
		{
			get{return _price;}
			set{_price = value;}
		}

		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		/// <value>The category.</value>
		public Category Category
		{
			get{return _category;}
			set{_category = value;}
		}

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description
		{
			get{return _description;}
			set{_description = value;}
		}

	}
}
