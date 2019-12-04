using System;

namespace M3
{
    class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                Console.Write("Skriv in ett tal: ");
                int tal1 = Convert.ToInt32(Console.ReadLine());

            
                Console.Write("Skriv in tal två: ");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Summan är: "+ Räkna(tal1,tal2));
            }
            catch (System.Exception)
            {
                Console.WriteLine("Detta var ingen siffra!");
                return;
                
            }
            
            
        }

    static int Räkna(int tal1, int tal2)
    {
            int summa=0;
            summa = tal1+tal2;
            return summa;
    }


    }
}
