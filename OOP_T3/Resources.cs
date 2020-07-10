using System;
using System.Collections.Generic;

namespace OOP_T1_P3
{	
	public class Resources
	{	
		private string _id;
		private bool _status;
		private ResourceCategory _category;

		public string Id 
		{ 
			get { return _id; }
			set { _id = value; }
		}

		public bool Status
		{
			get { return _status; }
			set { _status = value; }
		}

		public ResourceCategory Category
		{
			get { return _category; }
			set { _category = value; }
		}

		public Resources(string id, bool status, ResourceCategory category)
		{
			this._id = id;
			this._status = status;
			this._category = category;
		}

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