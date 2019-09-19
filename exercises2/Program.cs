using System;
using System.Threading;

namespace exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("\nSkriv in ett namn: ");
                name[i] = Console.ReadLine();

            }
            Console.Clear();
            Console.WriteLine("\nLaddar.");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("\nLaddar...");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("\nLaddar....");
            Thread.Sleep(700);
            Console.Clear();

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("\n" + name[i]);
            }

            Console.ReadLine();
        }
    }
}
