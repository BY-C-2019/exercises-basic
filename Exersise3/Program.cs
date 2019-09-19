using System;

namespace Exersise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //omvandla decimal till heltal
            Console.WriteLine("Det här programmet omvandlar decimaltal till heltal. Skriv in ett decimaltal, tack!");
            string input = Console.ReadLine();
            float decimaltal = float.Parse(input);
            int heltal = (int)Math.Round(decimaltal);
            Console.WriteLine("Det avrundade talet är: " + heltal);
        }
    }
}
