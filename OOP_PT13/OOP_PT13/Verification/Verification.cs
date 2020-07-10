using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public abstract class Verification
	{
		/// <summary>
		/// The acc npassword.
		/// </summary>
		protected Dictionary<string, string> _accNpassword;
		public Verification()
		{
		}

		/// <summary>
		/// Verication.
		/// </summary>
		public abstract bool Verify();

		/// <summary>
		/// Add the specified account and password.
		/// </summary>
		public abstract void Add(string acc, string pass);

		/// <summary>
		/// Remove the specified account.
		/// </summary>
		public abstract void Remove(string acc);


	}
}
