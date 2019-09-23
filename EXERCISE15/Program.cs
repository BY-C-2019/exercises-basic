using System;

namespace EXERCISE15
{
    class Program
    {
        static void Main(string[] args)
        {
            AdderaText("Hej", "på dig");
            // Console.Write("Skriv in den första texten:");
            // string a = Console.ReadLine();
            // Console.Write("Skriv in den andra texten:");
            // string b = Console.ReadLine();
            // Console.WriteLine(Addera(string a, string b));
            
        }

        static string AdderaText(string a, string b) 
        {
            //Två texter ska vara indata
            //Metoden ska returnera en string där dessa två texter är sammanslagna
            //De båda texterna skrivs ut tillsammans
            string nyText = a + b;
            return nyText; 
            Console.WriteLine(nyText);
        }
    }
}
