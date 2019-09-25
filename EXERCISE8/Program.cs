using System;

namespace EXERCISE8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv ett program som simulerar en bank. 
            //Man ska kunna sätta in pengar och ta ut pengar, 
            //Kolla saldo. 
            //Detta görs via en meny som du ska göra med switch-sats. 
            //Observera att du bör jobba med loopar i denna uppgift!



            int saldo;
            saldo = 0;
            int nr;
            bool isInTheBank = true;
            
            Console.WriteLine("Hej och välkommen till banken");

            while (isInTheBank)
            {
            Console.WriteLine("Här är de val du kan göra:");
            Console.WriteLine("1] Sätta in pengar på ditt konto.");
            Console.WriteLine("2] Ta ut pengar från ditt konoto.");
            Console.WriteLine("3] Få reda på saldot på ditt konto.");
            Console.WriteLine("4] Avsluta programmet och lämna banken.");
            Console.WriteLine("Vad vill du göra?:");
            nr = Convert.ToInt32(Console.ReadLine());

                switch (nr)
                {
                    case 1: //ska kunna sätta in pengar
                        Console.WriteLine("Ange hur mycket pengar du vill sätta in:");
                        int plus = Convert.ToInt32(Console.ReadLine());
                        saldo = saldo + plus;
                        Console.WriteLine("Du har nu satt in " + plus + " på ditt konto.");
                        break;

                    case 2: //ska kunna ta ut pengar
                        Console.WriteLine("Ange hur mycket pengar du vill ta ut:");
                        int minus = Convert.ToInt32(Console.ReadLine());
            
                        if (saldo < minus)
                        {
                        Console.WriteLine("Du har inte tillräckligt med pengar på ditt konto");
                        saldo = 0;
                        }
                        else
                        {
                        Console.WriteLine("Nu har du tagit ut " + minus + " från ditt konto.");
                        saldo = saldo - minus;
                        }
                        break;

                    case 3: //ska kunna kolla saldo
                        Console.WriteLine("Så här mycket pengar har du på ditt konto: " + saldo);
                        saldo = saldo;
                        break;

                    case 4: //Lämna banken och avsluta programmet
                        Console.WriteLine("Tack för ditt besök, programmet avslutas nu.");
                        isInTheBank = false;
                        break;

                    default:
                        Console.WriteLine("Nu blev det fel. Starta om!");
                        break;

                }
            }

        }
    }
}
