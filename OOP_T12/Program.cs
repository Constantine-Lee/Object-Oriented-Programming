using System;

namespace OOP_T1_P3
{
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{	
			
			Resources[] arrayResources = new Resources[4];
			arrayResources[0] = new Worker("996", true, 1, 2);
			arrayResources[1] = new Document("222", true, "OOP");
			arrayResources[2] = new Vehicle("007", true);
			arrayResources[3] = new Product("888", true);

			DeployAll(arrayResources);
			Console.ReadLine();
		}

		/// <summary>
		/// Deploies all.
		/// </summary>
		/// <param name="Resources">Resources.</param>
		public static void DeployAll( Resources[] Resources) 
		{
			for (int i = 0; i < Resources.Length; i++)
			{
				Console.WriteLine("ID:{0}\nStatus:{1}\n{2}\n", Resources[i].Id, Resources[i].Status, Resources[i].Deploy());
			} 
		}
	}
}
