using System;

namespace M2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening: ");
            string meningEtt= Console.ReadLine();
            Console.WriteLine("Skriv en mening till: ");
            string meningTvå = Console.ReadLine();
            Console.WriteLine(Meningar(meningEtt,meningTvå));
        }


        static string Meningar(string meningEtt, string meningTvå)
        {
            string meningar = meningEtt+" "+ meningTvå;
            return meningar;
        }
    }
}
