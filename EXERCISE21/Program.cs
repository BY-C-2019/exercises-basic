using System;

namespace EXERCISE21
{
    class Program
    {
        static double SekToEur(int money)
        {
            double eur;
            eur = money / 10.68;
            return eur;
        }

        static double SekToDollar(int money)
        {
            double dollar;
            dollar = money / 9.72;
            return dollar;
        }

        static double SekToDanish(int money)
        {
            double danska;
            danska = money / 1.43;
            return danska;
        }
        static void Main(string[] args)
        {
            //En meny med olika val
            //Skapar menyn med en switch
            //Meny 1) Omvandla sek till euro
            // Meny 2) Omvandla sek till dollar
            //Meny 3) Omvanlda sek till danska kronor
            //Metoder som anropas i menyvalen

            int money;

            Console.WriteLine("Hej och välkommen till den här växelstationen!");
            Console.WriteLine("Här kan du välja mellan att växla dina svenska pengar till följande valutor:");
            Console.WriteLine("1: Euro");
            Console.WriteLine("2: Dollar");
            Console.WriteLine("3: Danska kronor");
            Console.WriteLine("Knappa in hur mycket pengar du vill växla här: ");
            money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Välj vilken valuta du vill omvandla till:");
            int nr = Convert.ToInt32(Console.ReadLine());

            switch (nr)
            {
                case 1: 
                    double eur = SekToEur(money);
                    Console.WriteLine("Du får då " + eur + " euro"); 
                    break;
                
                case 2:
                    double dollar = SekToDollar(money);
                    Console.WriteLine("Du får då " + dollar + " dollar"); 
                    break;
                
                case 3:
                    double danish = SekToDanish(money);
                    Console.WriteLine("Du får då " + danish + " danska kronor"); 
                    break;

                default:
                    Console.WriteLine("DET BLEV FEL!");
                    break;
            }
        }
    }
}
