namespace Assignment1
{
    class PetSimulator
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pet Care Sim!");

            // Pet creation
            Console.Write("\n Please choose a type of pet: \n 1. Dog \n 2. Rabbit \n 3. Cat \n 4. Pig \n");
            string petChoice = Console.ReadLine();
            string petType; // To store the type of pet selected

            switch (petChoice)
            {
                case "1":
                    petType = "Dog";
                    Console.WriteLine("You have chosen a Dog. What will you like to name your pet?");
                    break;

                case "2":
                    petType = "Rabbit";
                    Console.WriteLine("You have chosen a Rabbit. What will you like to name your pet?");
                    break;
                case "3":
                    petType = "Cat";
                    Console.WriteLine("You have chosen a Cat. What will you like to name your pet?");
                    break;
                case "4":
                    petType = "Pig";
                    Console.WriteLine("You have chosen a Pig. What will you like to name your pet?");
                    break;
                default:
                    Console.WriteLine("Invalid pet type choice. You will be given a dog.");
                    petType = "Dog";
                    break;
            }

            Console.Write("User Input: ")
            string petName = Console.ReadLine();

            Console.WriteLine("Welcome " + petName + "! Let's take good care of him.")

            // Pet attributes
            int hunger = 5;
            int happiness = 5;
            int health = 5;

                }
            }
        }
    }
}