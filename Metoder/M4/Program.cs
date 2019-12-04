using System;

namespace M4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Skriv in ett tal: ");
                double tal = Convert.ToInt32(Console.ReadLine());

            
                
                Console.WriteLine("Sammanlagda summan blir: "+ RäknaMoms(tal)+"kr.");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Detta var ingen siffra!");
                return;
                
            }
        }
        static double RäknaMoms(double värde)
        {      double summa;

                summa=värde*1.25;
                return summa;
        }
    }
}
