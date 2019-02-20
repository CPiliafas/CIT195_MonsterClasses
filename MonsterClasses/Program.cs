using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                ID = 357,
                Name = "Suzy",
                Age = 478,
                HasGills = true,
                IsActive = true,
                SeaName = "Baltic Sea"
            };
        }
        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                ID = 80,
                Name = "Sid",
                Age = 36,
                HasSpaceShip = true,
                IsActive = true
            };
        }

        static ForestMonster InitializeForestMonster()
        {
            return new ForestMonster()
            {
                ID = 294,
                Name = "Sammy",
                Age = 23,
                HasHorns = true,
                IsActive = true
            };
        }

        static void DisplayMenu()
        {
            bool exitMenu = false;

            SeaMonster suzy = InitializeSeaMonster();
            SpaceMonster sid = InitializeSpaceMonster();
            ForestMonster sammy = InitializeForestMonster();

            do
            {
                DisplayHeader("Menu");
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("2) Exit");
                Console.WriteLine("3) Add a Sea Monster");
                Console.Write("Enter Choice:");
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        DisplayMonsterInfoScreen(suzy, sid, sammy);
                        break;
                    case 2:
                        exitMenu = true;
                        break;
                    case 3:
                        CreateSeaMonster(suzy);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!exitMenu);
        }

        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster, ForestMonster forestMonster)
        {
            DisplayHeader("Monster Information");

            DisplaySeaMonster(seaMonster);
            Console.WriteLine();
            DisplaySpaceMonster(spaceMonster);
            Console.WriteLine();
            DisplayForestMonster(forestMonster);

            DisplayContinuePrompt();
        }

        private static void DisplaySpaceMonster(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.ID}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Active: {(spaceMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Has Spaceship: {(spaceMonster.HasSpaceShip ? "Yes" : "No")}");
            spaceMonster.Greeting();
            spaceMonster.IsHappy();
            Console.WriteLine($"You attack {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()}");
        }

        private static void DisplaySeaMonster(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.ID}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Active: {(seaMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Has Gills: {(seaMonster.HasGills ? "Yes" : "No")}");
            Console.WriteLine($"Sea Name: {seaMonster.SeaName}");
            seaMonster.Greeting();
            seaMonster.IsHappy();
        }

        private static void DisplayForestMonster(ForestMonster forestMonster)
        {
            Console.WriteLine($"Id: {forestMonster.ID}");
            Console.WriteLine($"Name: {forestMonster.Name}");
            Console.WriteLine($"Age: {forestMonster.Age}");
            Console.WriteLine($"Active: {(forestMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine($"Has Horns: {(forestMonster.HasHorns ? "Yes" : "No")}");
            forestMonster.Greeting();
            forestMonster.IsHappy();
            Console.WriteLine($"You hug {forestMonster.Name} and they {forestMonster.MonsterHugResponse()}");
        }

        private static void CreateSeaMonster(SeaMonster seaMonsters)
        {
            SeaMonster newSeaMonster = new SeaMonster();

            DisplayHeader("Add a Sea Monster");

            Console.Write("Enter Name:");
            newSeaMonster.Name = Console.ReadLine();
            Console.Write("Enter ID:");
            int seaMonsterID = int.Parse(Console.ReadLine());
            newSeaMonster.ID = seaMonsterID;
            Console.Write("Has Gills:");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                newSeaMonster.HasGills = true;
            }
            else
            {
                newSeaMonster.HasGills = false;
            }
            Console.Write("Is Active:");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                newSeaMonster.IsActive = true;
            }
            else
            {
                newSeaMonster.IsActive = false;
            }
            Console.Write("Enter Sea Name:");
            newSeaMonster.SeaName = Console.ReadLine();
            
            
            

            DisplayContinuePrompt();
        }
        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tWelcome to my Monster App.");
            DisplayContinuePrompt();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tThank you for using my Monster App.");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        static void DisplayHeader(string headText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(headText);
            Console.WriteLine();
        }
    }
}
