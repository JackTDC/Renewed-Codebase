using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("YOOO Welcome to number guesser");
        Console.WriteLine("Think of a number from 1 to 1000");


        int max = 1000;
        int min = 1;
        int avg = 500;

        Console.Write("Is your number higher than 500 (Y/H/L) : ");
        char inp = Convert.ToChar(Console.ReadLine());

        while (inp != 'Y')
        {
            if (inp == 'H')
            {
                min = avg;
                avg = (avg + max) / 2;

            }
            else if (inp == 'L')
            {
                max = avg;
                avg = (avg + min) / 2;

            }

            Console.Write("Is your number higher than " + avg + " (Y/H/L) : ");
            inp = Convert.ToChar(Console.ReadLine());

        }

        Console.WriteLine("HA! I guessed your number");
    }
}