using System;

namespace M5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Skriv in ett tal: ");
                double tal1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Skriv in momsen: ");
                double tal2 = Convert.ToInt32(Console.ReadLine());
            
                
                Console.WriteLine("Sammanlagda summan blir: "+ RäknaMoms(tal1,tal2)+"kr.");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Detta var ingen siffra!");
                return;
                
            }
        }
        static double RäknaMoms(double värde,double moms)
        {       double summa;
                moms=moms/100;
                summa=(moms+1)*värde ;
                
                return summa;
        }
    
        
    }
}
