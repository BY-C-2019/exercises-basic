using System;

namespace Metoder_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv ett pris: ");

            int userInput = Convert.ToInt32(Console.ReadLine());

            CountMoms(userInput);

            
        }

        static void CountMoms(int value)
        {
            const double moms = 0.25;

            double medMoms = value * (moms + 1);
            double utanMoms = value * moms;

            Console.WriteLine("Momsen är: " + utanMoms);
            Console.WriteLine("Priset med moms blir: " + medMoms);
            
        }
    }
}
