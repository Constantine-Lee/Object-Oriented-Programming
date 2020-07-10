using System;

namespace OOP_PT13_3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			AdministratorAccount admin = new AdministratorAccount();
			StaffAccount staff = new StaffAccount();
			UserAccount exec = new UserAccount();

			while (true)
			{
				string chooseAccount = "", chooseModule = "";
				Console.WriteLine("\nActivate Administrator Account or Staff Account ?");
				Console.WriteLine("1:Administrator\n2:Staff");

				chooseAccount = Console.ReadLine();
		

				switch (chooseAccount)
				{
					//Choose Admin
					case "1":
						//Dynamic Binding. Change the pointer in v-ptr table to admin override function.
						exec = admin;
						while (true)
						{
							
							AskBasicModule();
							Console.WriteLine("3 :UserManagementModule");
							Console.WriteLine("4 :Switch account?");
							chooseModule = Console.ReadLine();
							BasicModule(chooseModule, exec);
							if (chooseModule == "3")
							{
								AdminExtraModule(admin);
							}
							if (chooseModule == "4")
							{
								break;
							}
						}
						break;
						
					//Choose Staff
					case "2":
						// Dynamic Binding.Change the pointer in v - ptr table to staff override function.
						exec = staff;
						while (true)
						{
							AskBasicModule();
							Console.WriteLine("3 :Switch account?");
							chooseModule = Console.ReadLine();
							BasicModule(chooseModule, exec);
							if (chooseModule == "3")
							{
								break;
							}
						}
						break;
					default:
						Console.WriteLine("Invaid Input");
						Console.ReadLine();
						break;
				}

			}
		}

		static void AdminExtraModule(AdministratorAccount admin)
		{
			Console.WriteLine("\nChoose which function to use.");
			Console.WriteLine("1:CreateNewUser\n2:ResetPassword\n3:DeleteUser");
			switch (Console.ReadLine())
			{
				case "1":
					admin.CreateNewUser();
					break;
				case "2":
					admin.ResetPassword();
					break;
				case "3":
					admin.DeleteUser();
					break;
				default:
					break;
			}
		}


		static void BasicModule(string chooseModule, UserAccount exec)
		{

			switch (chooseModule)
			{
				case "1":
					exec.SetModule("ProductManagementModule");
					ChooseFunction(exec);
					break;
				case "2":
					exec.SetModule("CategoryManagementModule");
					ChooseFunction(exec);
					break;
				default:
					break;
			}
		}

		static void ChooseFunction(UserAccount exec)
		{
			Console.WriteLine("\nChoose which function to use.");
			Console.WriteLine("1:Add\n" +
								  "2:Edit\n" +
								  "3:Remove");
			switch (Console.ReadLine())
			{
				case "1":
					exec.Add();
					break;
				case "2":
					exec.Edit();
					break;
				case "3":
					exec.Remove();
					break;
				default:
					break;
			}
		}

		static void AskBasicModule()
		{
			Console.WriteLine("\nChoose which module to use.");
			Console.WriteLine("1 :ProductManagementModule\n" +
							  "2 :CategoryManagementModule");
		}
	}
}
