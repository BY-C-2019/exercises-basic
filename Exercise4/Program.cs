using System;

namespace Exercise4
{
    class Program
    {        static void Main(string[] args)
        {
            //Användaren ska mata in sitt namn
            Console.WriteLine("Skriv in vad du heter!");
            string namn = Console.ReadLine();
            //Hälsa användaren välkommen!
            Console.WriteLine("Välkommen " + namn + "!");
            //Användaren ska mata in sin ålder  
            Console.WriteLine("Skriv in hur gammal du är!");
            string input = Console.ReadLine();
            //Användarens ålder ska sparas undan i en lämplig variabel
            int age = Convert.ToInt32(input);
            //Räkna ut hur många dagar som användaren har levt
            int summaDays = age*365;
            if (summaDays >20000)
            {
                Console.WriteLine("Oj då! Bra jobbat.");
            }
            else if (summaDays <400)
            {
                Console.WriteLine("Du måste vara ett väldigt litet barn!");
            }
            else 
            {
            Console.WriteLine("Du har levt i " + summaDays + " antal dagar. Vad kul!");    
            }
        }
    }
}
