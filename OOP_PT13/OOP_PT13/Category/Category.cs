using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public class Category: EntityID
	{
		/// <summary>
		/// The type.
		/// </summary>
		private string _type;

		/// <summary>
		/// Initializes a new instance of the Category class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="type">Type.</param>
		public Category(int id, string type): base(id)
		{
			Type = type;
		}

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string Type
		{
			get{return _type;}
			set{_type = value;}
		}
	}
}
