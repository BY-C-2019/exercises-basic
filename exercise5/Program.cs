using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Vad heter du? ");
            string name = Console.ReadLine();
            Console.WriteLine("Välkommen " + name);

            Console.WriteLine("Hur gammal är du? ");
            string input = Console.ReadLine();

            int age = Convert.ToInt32(input);
            int daysYouHaveLived = age * 365;

            Console.WriteLine("Du har levt i " + daysYouHaveLived + " dagar! ");
        }
    }
}
