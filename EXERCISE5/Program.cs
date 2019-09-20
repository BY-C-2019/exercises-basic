using System;

namespace EXERCISE5
{
    
    class Program
    {
        //Fråga om det är fint väder
        //Om användaren svarar j – vi går på picknik

    
        static void Main(string[] args)
        {
            Console.WriteLine("Är det fint väder? Svara j eller n");
            string svar;
            svar = Console.ReadLine().ToLower();

            if(svar =="j")
            {
                Console.WriteLine("Vi går på picknick");
            }
            else if (svar == "n")
            {
                Console.WriteLine("Vi stannar inne och läser en bok!");
            }
            //Om användaren matar in något annat än n,N,j,J – programmet skriver ut "Jag förstår inte"
            if(svar != "j" || svar!= "n")
            {
                Console.WriteLine("Jag förstår inte!");
            }
        }
    }
}
