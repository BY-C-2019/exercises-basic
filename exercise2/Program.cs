using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Tal 1: ");
			string inputOne = Console.ReadLine();
			Console.Write("Tal 2: ");
			string inputTwo = Console.ReadLine();

			int numberOne = Convert.ToInt32(inputOne);
			int numberTwo = Convert.ToInt32(inputTwo);
			int sum = numberOne + numberTwo;

            Console.WriteLine("Summan är: " + sum);
        }
    }
}
