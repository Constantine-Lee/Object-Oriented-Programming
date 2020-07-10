using System;
namespace OOP_PT13_3
{
	public class AdministratorAccount: UserAccount
	{
		
		public AdministratorAccount()
		{
			/// <summary>
			/// Initialize a new derived verification component. 
			/// </summary>
			_verify = new AdminVerification();
		}

		/// <summary>
		/// Creates the new user. First check for access status, if false then give the chance to log in with correct username and password. If true then perform the function. 
		/// </summary>
		public void CreateNewUser()
		{
			if (_accessStatus == false)
			{
				if (_verify.Verify())
				{
					Console.WriteLine("\nAccount Creation Panel.");
					_accessStatus = true;
					_verify.Add(GetUser(), GetPass());
				}
				return;
			}
			Console.WriteLine("\nAccount Creation Panel.");
			_verify.Add(GetUser(), GetPass());
		}

		/// <summary>
		/// Resets the password. First check for access status, if false then give the chance to log in with correct username and password. If true then perform the function. 
		/// </summary>
		public void ResetPassword()
		{
			string accNo = "";
			if (_accessStatus == false)
			{
				if (_verify.Verify())
				{
					Console.WriteLine("\nPassword Reset Panel.");
					_accessStatus = true;
					accNo = GetUser();
					_verify.Remove(accNo);
					_verify.Add(accNo, GetPass());
					AnnounceOperationSuccess();
				}
				return;
			}
			Console.WriteLine("\nPassword Reset Panel.");
			accNo = GetUser();
			_verify.Remove(accNo);
			_verify.Add(accNo, GetPass());
			AnnounceOperationSuccess();
		}

		/// <summary>
		/// Deletes the user. First check for access status, if false then give the chance to log in with correct username and password. If true then perform the function. 
		/// </summary>
		public void DeleteUser()
		{
			if (_accessStatus == false)
			{
				if (_verify.Verify())
				{
					Console.WriteLine("\nUser Deletion Panel.");
					_accessStatus = true;
					_verify.Remove(GetUser());
					AnnounceOperationSuccess();
				}
				return;
			}
			Console.WriteLine("\nUser Deletion Panel.");
			_verify.Remove(GetUser());
			AnnounceOperationSuccess();
		}

		/// <summary>
		/// Generates the sales report.
		/// </summary>
		public void GenerateSalesReport()
		{
		}

		/// <summary>
		/// Prints the sales.
		/// </summary>
		public void PrintSales()
		{
		}	

		/// <summary>
		/// Gets the user.
		/// </summary>
		private string GetUser()
		{
			Console.WriteLine("Enter user accound No.");
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

		/// <summary>
		/// Announces the operation success.
		/// </summary>
		private void AnnounceOperationSuccess()
		{
			Console.WriteLine("\nOperation success!");
			Console.ReadLine();
		}
	}
}
