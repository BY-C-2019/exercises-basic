using System;

namespace exercise19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett decimaltal: ");
            double tal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(tal + " avrundat blir: " + ToPrecentage(tal));
        }
        static double ToPrecentage(double tal)
        {
            double helTal = Math.Round(tal);
            return helTal;
        }
    }
}