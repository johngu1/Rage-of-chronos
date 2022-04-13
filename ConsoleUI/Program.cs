/**
* 2/12/2022
* CSC 153
* Nguyen Johnny
* Build a program with 4 arrays, with 2 lists, while having a modified menu
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//variable
			bool exit = false;
            int roomLocation = 0;

			//test for stream writer
			string room = " Main Enterence,  Hallway ,  Fountain room ,  Rest Area ,  Town";

			StreamWriter outputFile;

            try
            {
				outputFile = File.CreateText("test.txt");

				outputFile.WriteLine(room);

				outputFile.Close();
            }
		     catch(Exception ex)
            {
				Console.WriteLine(ex.Message);
				Console.ReadLine();
            }

			// arrays
			string[] rooms = new string[5];
			string[] weapons = new string[4] { "Eye of Horus", "AC-011 Blade" , "Tome of Destruction" , "Excalibur" };
			string[] potions = new string[2] { "energy potion", "recovery potion"};
			string[] treasures = new string[3] { "Time enhancing gloves", "energy pendent", "Health bracers" };

			//lists
			List<string> items = new List<string>() { "bombs", "ropes", "coins", "knife" };
			List<string> mobs = new List<string>() {  "lava golem", "construct soldier", "evil clone", "zombie mage", "raid raptors"};

			//Main menu

			while (exit == false)
			{

				Console.WriteLine($"You are in the{rooms[roomLocation]}");
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
