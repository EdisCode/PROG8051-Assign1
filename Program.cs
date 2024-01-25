﻿using System;

namespace Assignment1
{
    class PetSimulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pet Care Sim!");

            // Pet creation
            Console.WriteLine("\n Please choose a type of pet: \n 1. Dog \n 2. Rabbit \n 3. Cat \n 4. Pig");
            Console.Write("\n User Input (1 - 4): ");

            string petChoice = Console.ReadLine();

            //string petType;

            switch (petChoice)
            {
                case "1":
                   // petType = "Dog";
                    Console.WriteLine("\n You have chosen a Dog. What will you like to name your pet?");
                    break;

                case "2":
                   // petType = "Rabbit";
                    Console.WriteLine("\n You have chosen a Rabbit. What will you like to name your pet?");
                    break;

                case "3":
                   // petType = "Cat";
                    Console.WriteLine("\n You have chosen a Cat. What will you like to name your pet?");
                    break;

                case "4":
                   // petType = "Pig";
                    Console.WriteLine("\n You have chosen a Pig. What will you like to name your pet?");
                    break;

                default:
                   // petType = "Dog";
                    Console.WriteLine("\n Invalid pet type choice. You will be given a dog.");
                    break;
            }

            // Naming pet
            Console.Write("\n Pet Name: ");
            string petName = Console.ReadLine();

            Console.WriteLine($"\n Welcome, {petName}! Let's take good care of her.");

            // Pet attributes
            int hunger = 5;
            int happiness = 5;
            int health = 5;

            Console.WriteLine($"\n {petName}'s Status:");
            Console.WriteLine($" - Hunger: {hunger}/10");
            Console.WriteLine($" - Happiness: {happiness}/10");
            Console.WriteLine($" - Health: {health}/10");

            // Main menu loop
            while (true)
            {
                // Pet Care Actions
                Console.WriteLine($"\n Main Menu: \n 1. Feed {petName} \n 2. Play with {petName} \n 3. Let {petName} rest \n 4. Check {petName}'s Status \n 5. Quit");

                Console.Write("\n Select an action (1 - 5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"\n {petName} is being fed. Feeding decreases hunger and slightly increases health.");
                        hunger = Math.Max(0, hunger - 2);
                        health = Math.Min(10, health + 1);
                        break;

                    case "2":
                        Console.WriteLine($"\n {petName} is playing. Playing increases happiness and slightly increases hunger.");
                        happiness = Math.Min(10, happiness + 2);
                        hunger = Math.Min(10, hunger + 1);
                        break;

                    case "3":
                        Console.WriteLine($"\n {petName} is resting. Resting improves health and decreases happiness slightly.");
                        health = Math.Min(10, health + 2);
                        happiness = Math.Max(0, happiness - 1);
                        break;

                    case "4":
                        Console.WriteLine($"\n {petName}'s Status:");
                        Console.WriteLine($" - Hunger: {hunger}/10");
                        Console.WriteLine($" - Happiness: {happiness}/10");
                        Console.WriteLine($" - Health: {health}/10");
                        break;

                    case "5":
                        Console.WriteLine("\n Thank you for playing!");
                        return;

                    default:
                        Console.WriteLine("\n Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

                
            }
        }
    }
}
