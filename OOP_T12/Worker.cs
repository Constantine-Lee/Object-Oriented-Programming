using System;
namespace OOP_T1_P3
{
	public class Worker: Resources
	{
		/// <summary>
		/// The hours worked.
		/// </summary>
		private int _hoursWorked;

		/// <summary>
		/// The rate per hour.
		/// </summary>
		private int _ratePerHour;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:OOP_T1_P3.Worker"/> class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="status">status.</param>
		/// <param name="hoursWorked">Hours worked.</param>
		/// <param name="ratePerHour">Rate per hour.</param>
		public Worker(string id, bool status, int hoursWorked, int ratePerHour):base(id, status)
		{
			this._hoursWorked = hoursWorked;
			this._ratePerHour = ratePerHour;
		}

		/// <summary>
		/// Gets or sets the hours worked.
		/// </summary>
		/// <value>The hours worked.</value>
		public int HoursWorked
		{
			get{return _hoursWorked;}
			set{_hoursWorked = value;}
		}

		/// <summary>
		/// Gets or sets the rate per hour.
		/// </summary>
		/// <value>The rate per hour.</value>
		public int RatePerHour
		{
			get{return _ratePerHour;}
			set{_ratePerHour = value;}
		}

		/// <summary>
		/// Deploy this instance.
		/// </summary>
		public override string Deploy()
		{
			return "Total Salary: "+_hoursWorked*_ratePerHour;
		}
	}
}
