using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.Write("Ange ett decimaltal:");
				string input = Console.ReadLine();
				double value = Convert.ToDouble(input);
				double closestInt = Math.Round(value);
				Console.WriteLine("Närmaste heltalet var: " + closestInt);
			}
			catch
			{
				Console.WriteLine("Snälla, du vet ju hur ett decimaltal ser ut 🤦‍");
			}
        }
    }
}
