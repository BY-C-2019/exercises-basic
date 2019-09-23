using System;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string answer;

            do
            {
                Console.WriteLine("Nu ska vi se om det är fint väder!");
                Console.WriteLine("Avsluta med [Q]");
                Console.WriteLine("Är det fint väder?");
                Console.Write("[J, N]>>");
                input = Console.ReadLine();
                answer = input.ToUpper();

                if (answer == "J")
                {
                    Console.WriteLine("Vi går på picknick!");
                    Console.ReadKey(); 
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Vi stannar inne och läser en bok.");
                    Console.ReadKey();
                }
                else if (answer == "Q")
                {
                    Console.WriteLine("Avslutar...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Jag förstår inte!?");
                    Console.ReadKey();
                }

            }while(true);
        }
    }
}
