using System;
namespace OOP_PT13_3
{
	public class Member: EntityID
	{
		/// <summary>
		/// The status.
		/// </summary>
		private bool _status;

		/// <summary>
		/// The details.
		/// </summary>
		private string _details;

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
		/// Gets or sets a value indicating whether this <see cref="T:OOP_PT13_3.Member"/> is status.
		/// </summary>
		/// <value><c>true</c> if status; otherwise, <c>false</c>.</value>
		public bool Status
		{
			get{return _status;}
			set{_status = value;}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:OOP_PT13_3.Member"/> class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="status">If set to <c>true</c> status.</param>
		/// <param name="details">Details.</param>
		public Member(int id, bool status, string details):base(id)
		{
			Status = status;
			Details = details;
		}
	}
}
