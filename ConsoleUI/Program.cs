using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
			bool exit = false;

			//Main menu

			while (exit == false)
			{

				Console.WriteLine("You are in ...");
				Console.WriteLine("1. Display Rooms");
				Console.WriteLine("2. Display Weapon");
				Console.WriteLine("3. Display Potion");
				Console.WriteLine("4. Display Treasure");
				Console.WriteLine("5. Display Items");
				Console.WriteLine("6. Display Mobs");
				Console.WriteLine("7. Exit");
				Console.Write("Enter a choice > ");
				string input = Console.ReadLine();

				if (input == "1")
				{
					//TODO
				}
				else if (input == "2")
				{
					exit = true;
				}
				else
				{
					Console.WriteLine("Not a choice!");
				}
			}
		}
    }
}
