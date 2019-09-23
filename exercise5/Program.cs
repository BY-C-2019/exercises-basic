using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int age;
            int daysAlive;

            Console.WriteLine("Hej! Vad heter du?");
            Console.Write(">>");
            input = Console.ReadLine();
            Console.WriteLine("Hej " + input + ". Hur gammal är du?");
            age = Convert.ToInt32(Console.ReadLine());
            daysAlive = age * 365;
            Console.WriteLine("Du har levt i ungefär " + daysAlive + " dagar.");
            Console.ReadKey();
        }
    }
}
