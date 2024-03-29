﻿using System;
using System.Collections.Generic;

namespace OOP_T1_P3
{	/// <summary>
	/// Resources.
	/// </summary>
	public class Resources
	{	
		private string _id;
		private bool _status;
		private ResourceCategory _category;
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		public string Id 
		{ 
			get { return _id; }
			set { _id = value; }
		}
		/// <summary>
		/// Gets or sets a value indicating this <see cref="T:OOP_T1_P3.Resources"/>'s status.
		/// </summary>
		/// <value><c>true</c> if status; otherwise, <c>false</c>.</value>
		public bool Status
		{
			get { return _status; }
			set { _status = value; }
		}
		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		/// <value>The category.</value>
		public ResourceCategory Category
		{
			get { return _category; }
			set { _category = value; }
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:OOP_T1_P3.Resources"/> class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="status">If set to <c>true</c> status.</param>
		/// <param name="category">Category.</param>
		public Resources(string id, bool status, ResourceCategory category)
		{
			this._id = id;
			this._status = status;
			this._category = category;
		}
		/// <summary>
		/// Deploy this instance.
		/// </summary>
		public string deploy()
		{	
			string messages;
			if (this._status == true)
			{
				switch (this._category)
				{	
					case ResourceCategory.Worker:
						messages = "Be alert on the hours worked!";
						return messages;
					case ResourceCategory.Document:
						messages = "Please timely update the report!";
						return messages;
					case ResourceCategory.Vehicle:
						messages = "Lorry/truck deployed!";
						return messages;
					case ResourceCategory.Product:
						messages = "Check the availability before deploy!";
						return messages;
					default:
						messages = "Please enter the appropriate";
						return messages;
				}
			}
			else return messages = "Resource failed to deploy.";

		}
	}
}