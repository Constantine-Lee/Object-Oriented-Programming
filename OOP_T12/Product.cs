using System;
namespace OOP_T1_P3
{
	public class Product: Resources
	{
		/// <summary>
		/// The availability.
		/// </summary>
		private int _availability;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:OOP_T1_P3.Product"/> class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="status">status.</param>
		public Product(string id, bool status) : base(id, status)
		{
			this._availability = 10;
		}

		/// <summary>
		/// Gets or sets the availability.
		/// </summary>
		/// <value>The availability.</value>
		public int Availability
		{
			get { return _availability; }
			set { _availability = value; }
		}

		/// <summary>
		/// Deploy this instance.
		/// </summary>
		public override string Deploy()
		{
			if (_availability > 0)
				return "Deployed success";
			return "Product not available";
		}		

	}


}
