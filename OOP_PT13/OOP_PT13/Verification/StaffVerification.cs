using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public class StaffVerification: Verification
	{
		/// <summary>
		/// Initializes a new instance of the StaffVerification class.
		/// </summary>
		public StaffVerification()
		{
			_accNpassword = new Dictionary<string, string>() { { "staff", "staff" } };
		}

		/// <summary>
		/// Verification.
		/// </summary>
		public override bool Verify()
		{
			Console.WriteLine("Authentication.");
			string accNo = GetUser();
			string password = GetPass();

			foreach (KeyValuePair<string, string> pair in _accNpassword)
			{
				if (pair.Key == accNo)
				{
					if (pair.Value == password)
					{
						Console.WriteLine("Successfully login.");
						Console.ReadLine();
						return true;
					}
				}
			}
			Console.WriteLine("Account No or Password incorrect...");
			Console.ReadLine();
			return false;
		}

		/// <summary>
		/// Add the specified account and password.
		/// </summary>
		/// <param name="acc">Acc.</param>
		/// <param name="pass">Pass.</param>
		public override void Add(string acc, string pass)
		{
			_accNpassword.Add(acc, pass);
		}

		/// <summary>
		/// Remove the specified acc.
		/// </summary>
		/// <param name="acc">Acc.</param>
		public override void Remove(string acc)
		{
			_accNpassword.Remove(acc);
		}

		/// <summary>
		/// Gets the user.
		/// </summary>
		/// <returns>The user.</returns>
		private string GetUser()
		{
			Console.WriteLine("Enter new user account No.");
			return Console.ReadLine();

		}

		/// <summary>
		/// Gets the password.
		/// </summary>
		private string GetPass()
		{
			Console.WriteLine("Enter password.");
			return Console.ReadLine();
		}
	}
}
