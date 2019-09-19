using System;

namespace Vektor
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vektor = new string[5];
            Console.WriteLine("Skriv in 5 namn");


            for (int i = 0; i < vektor.Length; i++)
            {
                Console.WriteLine("Skriv in namn "+i);
                vektor[i]=Console.ReadLine();

            }

            for (int i = 0; i < vektor.Length; i++)
            {
                Console.WriteLine(vektor[i]);

            }
            Console.ReadLine();
        }
    }
}
