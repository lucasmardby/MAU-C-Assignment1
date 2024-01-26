﻿namespace ConsoleApps
{
    internal class Pet
    {
        private string name = null!;
        private int age;
        private bool isFemale;

        public void PetStart()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Pet class!");
            Console.WriteLine();

            ReadAndSavePetData();
            DisplayPetInfo();

            HelperMethods.ConfirmationButton();
        }

        private void ReadAndSavePetData()
        {
            Console.WriteLine("What is the name of your pet?");
            name = Console.ReadLine();

            /*Checks if pet name ends with 's' or not,
            to write a grammatically correct sentence*/
            if (name.ToLower().EndsWith('s'))
            {
                Console.WriteLine($"What is {name}' age?");
            }
            else
            {
                Console.WriteLine($"What is {name}'s age?");
            }
            var validInput = false;
            do
            {
                var readResult = Console.ReadLine();
                if (int.TryParse(readResult, out _))
                {
                    validInput = true;
                    age = Convert.ToInt32(readResult);
                }
                else
                {
                    Console.WriteLine("Try again. Enter a proper number for the age.");
                }
            } while (validInput == false);
            
            Console.WriteLine("Is your pet a female? (y/n)");
            //do-while loop to make sure user input is valid
            do
            {
                var readResult = Console.ReadLine().ToLower().Trim();
                if (readResult == "y")
                {
                    isFemale = true;
                    validInput = true;
                }
                else if (readResult == "n")
                {
                    isFemale = false;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Please try again by entering yes or no. Is your pet a female? (y/n)");
                    validInput = false;
                }
            } while (validInput == false);
        }
        private void DisplayPetInfo() 
        {
            Console.WriteLine("------");
            Console.WriteLine($"Name: {name}, Age: {age}");
            if (isFemale == true)
            {
                Console.WriteLine("She's so cute!");
            }
            else
            {
                Console.WriteLine("He's so cute!");
            }
            Console.WriteLine("------");
        }

    }

    

}
