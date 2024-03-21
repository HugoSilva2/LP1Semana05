using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
           if (args.Length != 2)  //if args length different than 2
            {
                Console.WriteLine("Usage: RanDice <number_of_dice> <seed>");
                return;
            }

            // Parsing command line arguments
            int numberOfDice, seed;
            try
            {
                numberOfDice = int.Parse(args[0]);
                seed = int.Parse(args[1]);
            }
            catch (FormatException) //To check if the format of an argument is invalid
            {
                Console.WriteLine("Invalid input format. Please enter integers for number of dice and seed.");
                return;
            }

            if (numberOfDice <= 0)
            {
                Console.WriteLine("Invalid number of dice. Please enter a positive integer.");
                return;
            }

            Random rand = new Random(seed);

            int sum = 0;
            for (int i = 0; i < numberOfDice; i++)
            {
                int roll = rand.Next(1, 7); // Generates a random number between 1 and 6 (inclusive)
                sum += roll;
            }

            Console.WriteLine($"Sum of die: {sum}");
        }
    }
}
