using System;
namespace OOP_PT13_3
{
	public class StaffAccount: UserAccount
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public StaffAccount()
		{
			/// <summary>
			/// Initialize a new derived verification component. 
			/// </summary>
			_verify = new StaffVerification();
		}
	}
}
