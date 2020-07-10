using System;
using System.Collections.Generic;

namespace OOP_T1_P3
{
	public class Project
	{
		/// <summary>
		/// The resources.
		/// </summary>
		private List<Resources> _resources;

		/// <summary>
		/// The status.
		/// </summary>
		private bool _status;

		/// <summary>
		/// Initializes a new instance of the Project class.
		/// </summary>
		public Project()
		{
			_resources = new List<Resources>();
			_status = false;
		}

		/// <summary>
		/// Gets the resources count.
		/// </summary>
		/// <value>The resources count.</value>
		public int ResourcesCount
		{
			get { return _resources.Count; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether this Project is status.
		/// </summary>
		public bool Status
		{
			get { return _status; }
			set { _status = value; }
		}

		/// <summary>
		/// Adds the resource.
		/// </summary>
		/// <param name="r">The red component.</param>
		public void AddResource(Resources r)
		{
			_resources.Add(r);
		}

		/// <summary>
		/// Removes the resource.
		/// </summary>
		/// <param name="r">The red component.</param>
		public void RemoveResource(Resources r)
		{
			_resources.Remove(r);
		}

		/// <summary>
		/// Gets the Project with the specified i.
		/// </summary>
		public Resources this[int i]
		{
			get { return _resources[i]; }
		}
	}
}
