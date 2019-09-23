using System;

namespace EXERCISE16
{
    class Program
    {
        //Skapa metoden Addera() som tar in två heltal och returnerar summan.
        static void AdderaSumma(int tal1, int tal2)
        {
            int summa;
            summa = tal1 + tal2;
            Console.WriteLine("Nu skriver vi ut summan av de två talen här:" + summa);
        }
        static void Main(string[] args)
        {
            AdderaSumma(8, 2);
        }
    }
}
