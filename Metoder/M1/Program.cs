using System;

namespace M1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt namn: ");
            string namn = Console.ReadLine();
            Console.WriteLine("Hej "+ namn+"!!");
        }

        static string DittNamn(string namn)
        {
                return namn;
        }
    }
}
