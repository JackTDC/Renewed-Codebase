using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guesser!");

        int min=0;
        int max=0;
        bool validInput = false;

        while (!validInput)
        {
            min = GetNumber("Enter the minimum number in the range: ");
            max = GetNumber("Enter the maximum number in the range: ");

            if (min > max)
            {
                Console.WriteLine("Minimum can't be larger than maximum. Please try again.");
            }
            else
            {
                validInput = true;
            }
        }

        Console.WriteLine("Think of a number between {0} and {1}", min, max);

        int guess = (min + max) / 2;

        while (true)
        {
            Console.Write("Is your number {0}? (Y/H/L): ", guess);
            char input = GetInput();

            if (input == 'Y')
            {
                Console.WriteLine("I guessed your number!");
                break;
            }
            else if (input == 'H')
            {
                min = guess + 1;
            }
            else if (input == 'L')
            {
                max = guess - 1;
            }


            guess = (min + max) / 2;
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int GetNumber(string prompt)
    {
        int number;

        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                return number;
            }



            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static char GetInput()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (input.Length == 1 && "YHL".Contains(input.ToUpper()))
            {
                return input.ToUpper()[0];
            }

            Console.WriteLine("Invalid input. Please enter Y, H, or L.");
        }
    }
}