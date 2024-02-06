using System;
using System.Globalization;
using System.Xml.Linq;

namespace PetSimulator
{
    //Main program of Virtual Pet Project
    class Program
    {

        static void Main(string[] args)
        {
            // Choose the pet and give a name
            Console.WriteLine("Welcome to Virtual Pet Simulator!");
            Console.Write("Please choose the pet type \n 1. Cat \n 2. Dog \n 3. Rabbit \n");
            Console.Write("Enter Input : ");
            string type = Console.ReadLine();
            Console.Write("Great!, you have choosen " + type + ". Now what would be the name of the pet\n");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome, " + name + "! Let's take a good care of you!! \n");

            // Pet care action
            int Hunger = 5;
            int Happiness = 5;
            int Health = 5;


            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nPlease choose pet care action: \n 1. Feed " + name + "\n 2. Play with " + name + "\n 3. Let " + name + " rest \n 4. Check " + name + "'s status \n 5. Exit");
                Console.Write("\nEnter Input : ");
                string action = Console.ReadLine();

                // 1. Feed the pet
                if (action == "1")
                {
                    Hunger -= 2;
                    Health++;
                    Console.WriteLine("You fed " + name + ". Now " + name + "'s hunger decreased and health slightly increased.");
                }

                //Play with the pet
                else if (action == "2")
                {
                    Happiness += 2;
                    Hunger++;
                    Console.WriteLine("You played with " + name + ". Now " + name + "'s happiness increased but hunger also slightly increased.");
                }

                // Rest for pet
                else if (action == "3")
                {
                    Health += 2;
                    Happiness--;
                    Console.WriteLine("You let " + name + " rest. Now " + name + "'s health improved, however happiness slightly decreased.");
                }

                // Check the status of pet
                else if (action == "4")
                {
                    Console.WriteLine("\nStatus of " + name + ":");
                    Console.WriteLine("- Hunger: " + Hunger);
                    Console.WriteLine("- Happiness: " + Happiness);
                    Console.WriteLine("- Health: " + Health);
                }
                //Exit
                else if (action == "5")
                {
                    exit = true;
                    break;
                }
                // Handle invalid input
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a vaid choice.");
                }

                // Time based changes: each action represents the passing of an hour
                if (action != "4")
                {
                    Hunger++;
                    Happiness--;
                    Health--;
                    Console.WriteLine("\nOne hour time passes... Hunger increases, happiness decreases and health decreases after one action");
                }

                // Consequences for neglect
                if(action != "4") 
                {
                    if (Hunger >= 8)
                    {
                        Health -= 2;
                        Console.WriteLine(name + " is very hungry! Health is deteriorated and is refusing to play.\n");                        
                    }
                    if (Happiness <= 2)
                    {
                        Health -= 2;
                        Console.WriteLine(name + " is very unhappy! Health is deteriorated.\n");

                    }
                }
            }
        }
    }
}
   