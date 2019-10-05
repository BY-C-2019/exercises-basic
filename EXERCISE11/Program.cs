using System;

namespace EXERCISE11
{
    class Program
    {
        static void Main(string[] args)

        //Skriv ett program som hämtar fem tal från användaren
        {
            //Använd en vektor för att spara talen.
            int[] userInput = new int[5];

            Console.WriteLine("Hej! Jag behöver din hjälp med att mata in fem stycken tal.");
            //Använd en forloop.
            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine("Vilket tal väljer du?");
                //try och cath som tar hand om användaren matar in tecken
                try
                {
                    int nr = Convert.ToInt32(Console.ReadLine());
                    userInput[i] = nr;
                }
                catch
                {
                    Console.WriteLine("Du får bara använda tal!");
                    //håller koll på index i vektorn så att den in räknar upp om användaren matar in 
                    //annat än siffor.
                    i--;
                }
            }


            Console.WriteLine("Det här är alla tal som du matade in:");

            // Som sedan skriver ut talen 
            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine(userInput[i]);
            }

            //skriver ut summan av talen
            int summa = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                summa = summa + userInput[i];
            }
            Console.WriteLine("Summan på dina tal är: " + summa);
        }
    }
}
