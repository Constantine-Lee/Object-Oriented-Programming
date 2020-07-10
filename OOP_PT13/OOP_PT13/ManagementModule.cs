using System;
namespace OOP_PT13_3
{
	public class ManagementModule
	{
		public ManagementModule()
		{
		}

		/// <summary>
		/// Polymorphism.
		/// </summary>
		public virtual void Add()
		{
			Console.WriteLine("This management module does not have this function.");
		}

		/// <summary>
		/// Polymorphism.
		/// </summary>
		public virtual void Edit()
		{
			Console.WriteLine("This management module does not have this function.");
		}

		/// <summary>
		/// Polymorphism.
		/// </summary>
		public virtual void Remove()
		{
			Console.WriteLine("This management module does not have this function.");
		}
	}
}
