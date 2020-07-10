using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public class Order: EntityID
	{
		/// <summary>
		/// The products.
		/// </summary>
		private List<Product> _products;

		/// <summary>
		/// The details.
		/// </summary>
		private string _details;

		/// <summary>
		/// The status.
		/// </summary>
		private bool _status;

		/// <summary>
		/// Initializes a new instance of the Order class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		public Order(int id) : base(id)
		{
			_products = new List<Product>();
		}

		/// <summary>
		/// Gets or sets the details.
		/// </summary>
		/// <value>The details.</value>
		public string Details
		{
			get{return _details;}
			set{_details = value;}
		}

		/// <summary>
		/// Changes the status.
		/// </summary>
		public void ChangeStatus()
		{
			if (_status)
			{
				_status = false;
			}
			_status = true;
		}





	}
}
