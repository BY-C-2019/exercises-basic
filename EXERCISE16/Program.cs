using System;

namespace EXERCISE16
{
    class Program
    {
        //Skapa metoden Addera() som tar in två heltal och returnerar summan.
        //static int AdderaSumma(int tal1, int tal2)
        // {
        //     int summa = tal1 + tal2;
        //     return summa;
        // }

        static double InkMoms(int tal, double tal2)
        {
            double moms = tal * ((tal2 / 100) + 1 );
            return moms;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in den summa du vill addera momsen till: ");
            int premoms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vilken momssats gäller?");
            int momssats = Convert.ToInt32(Console.ReadLine());
            double moms = InkMoms(premoms, momssats);
            Console.WriteLine("Inklusive moms blir detta: " + moms + " sek.");

            // Console.WriteLine("Skriv in det första talet här:");
            // int tal1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Skriv in det andra talet här:");
            // int tal2 = Convert.ToInt32(Console.ReadLine());
            // int summa = AdderaSumma(tal1, tal2);
            // Console.Write("Detta är summan: " + summa);
            // Console.ReadKey();
        }
    }
}
