using System;
using System.Collections.Generic;

namespace OOP_T1_P3
{	
	/// <summary>
	/// Resources.
	/// </summary>
	public class Resources
	{	
		/// <summary>
		/// The identifier.
		/// </summary>
		private string _id;
		/// <summary>
		/// The status.
		/// </summary>
		private bool _status;
		/// <summary>
		/// The category.
		/// </summary>
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
		/// Gets or sets a value indicating whether this Resources is status.
		/// </summary>
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
		/// Initializes a new instance of the Resources class.
		/// </summary>
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