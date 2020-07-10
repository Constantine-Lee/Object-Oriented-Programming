using System;
namespace OOP_T1_P3
{
	public class Vehicle: Resources
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:OOP_T1_P3.Vehicle"/> class.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="status">status.</param>
		public Vehicle(string id, bool status): base(id, status)
		{
		}

		/// <summary>
		/// Deploy this instance.
		/// </summary>
		public override string Deploy()
		{
			return "Lorry/truck deployed!";
		}
	}
}
