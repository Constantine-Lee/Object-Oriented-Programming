using System;
using System.Collections.Generic;

namespace OOP_PT13_3
{
	public class AdminVerification:Verification
	{
		/// <summary>
		/// Initializes a new instance of the AdminVerification class.
		/// </summary>
		public AdminVerification()
		{
			_accNpassword = new Dictionary<string, string>(){ { "admin", "admin" } };
		}

		/// <summary>
		/// Verification.
		/// </summary>
		public override bool Verify()
		{
			Console.WriteLine("\nAuthentication.");
			string accNo = GetUser();
			string password = GetPass();

			foreach (KeyValuePair<string, string> pair in _accNpassword)
			{
				if (pair.Key == accNo)
				{
					if (pair.Value == password)
					{
						Console.WriteLine("\nAuthentication successful.");
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
		/// Remove the specified account.
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
			Console.WriteLine("Enter user account No.");
			return Console.ReadLine();

		}

		/// <summary>
		/// Gets the password.
		/// </summary>
		/// <returns>The pass.</returns>
		private string GetPass()
		{
			Console.WriteLine("Enter password.");
			return Console.ReadLine();
		}
	}
}
