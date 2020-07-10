using System;
using System.Collections.Generic;

namespace OOP_T1_P3
{   /// <summary>
	/// Resources.
	/// </summary>
	public abstract class Resources
	{
		private string _id;
		private bool _status;

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
		/// Initializes a new instance of the <see cref="T:OOP_T1_P3.Resources"/> class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="status">If set to <c>true</c> status.</param>
		/// <param name="category">Category.</param>
		public Resources(string id, bool status)
		{
			this._id = id;
			this._status = status;
		}

		public Resources()
		{
		}
		/// <summary>
		/// Deploy this instance.
		/// </summary>
		public abstract string Deploy();
	}
}