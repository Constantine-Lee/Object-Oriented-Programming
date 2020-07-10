using System;
namespace OOP_PT13_3
{
	public class EntityID
	{
		/// <summary>
		/// The identifier.
		/// </summary>
		protected int _id;

		public EntityID(int id)
		{
			_id = id;
		}

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		public int Id
		{
			get{return _id;}
			set{_id = value;}
		}
	}
}
