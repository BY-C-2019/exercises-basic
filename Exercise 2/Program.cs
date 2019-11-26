using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Skriv in ett decimial tal: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            int rounded = (int)Math.Round(userInput, 0);

            Console.WriteLine("Svaret blir: " + rounded);


        }
    }
}
