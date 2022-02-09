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
			//variable
			bool exit = false;
			int roomLocation = 0;

			// arrays
			string[] rooms = new string[5] { "Enterence", "Hallway" , "" , "room4" , "room5" };
			string[] weapons = new string[4] { "Eye of Horus", "AC-011 Blade" , "Tome of Destruction" , "Excalibur" };
			string[] potions = new string[2] { "energy potion", " recovery potion"};
			string[] treasures = new string[3] { "Time enhancing gloves", "", "" };

			//lists
			List<string> items = new List<string>() { "item1", "item2", "item3", "item4" };
			List<string> mobs = new List<string>() {  "mob1", "mob2", "mob3", "mob4", "mob5"};

			//Main menu

			while (exit == false)
			{

				Console.WriteLine($"You are in ...{rooms[roomLocation]}");
				Console.WriteLine("1. Display Rooms");
				Console.WriteLine("2. Display Weapon");
				Console.WriteLine("3. Display Potion");
				Console.WriteLine("4. Display Treasure");
				Console.WriteLine("5. Display Items");
				Console.WriteLine("6. Display Mobs");
				Console.WriteLine("7. Exit");
				Console.Write("Enter a choice > ");
				string input = Console.ReadLine();

				switch(input.ToLower())
                {
					case "1":
						foreach(string value in rooms)
                        {
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "2":
						foreach (string value in weapons)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "3":
						foreach (string value in potions)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "4":
						foreach (string value in treasures)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "5":
						foreach (string value in items)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "6":
						foreach (string value in mobs)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "rooms":
						foreach (string value in rooms)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "weapons":
						foreach (string value in weapons)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "potions":
						foreach (string value in potions)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "treasures":
						foreach (string value in treasures)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "items":
						foreach (string value in items)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "mobs":
						foreach (string value in mobs)
						{
							Console.WriteLine(value);
						}
						Console.WriteLine();
						break;
					case "n":
						if(roomLocation != 4)
                        {
							roomLocation++;
                        }
						else
                        {
							Console.WriteLine("You can not go further north");
						}
						Console.WriteLine();
						break;
					case "s":
						if (roomLocation != 0)
						{
							roomLocation--;
						}
						else
						{
							Console.WriteLine("You can not go further south");
						}
						Console.WriteLine();
						break;
					case "7":
						exit = true;
						break;
					default:
						Console.WriteLine("Not a choice");
						Console.WriteLine();
						break;
				}
			}
		}
    }
}
