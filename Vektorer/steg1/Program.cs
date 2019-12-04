using System;

namespace steg1
{
    class Program
    {
        static void Main(string[] args)
        {   
            string[] namn = new string[5];
            Console.WriteLine("Skriv in 5 namn!");

            try
            {
                for (int i = 0; i < namn.Length; i++)
            {       Console.WriteLine("Skriv in namn nummer: "+ i);
                    namn[i] = Console.ReadLine();
                    
            }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Du måste skriva ett nummer mellan 0-4");
                throw;
            }
            
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine("Namn: "+namn[i]);
            }

            //////////////////////////////////////
            try
            {
                    int index=0;
                    Console.WriteLine("Välj nummer 0-5");
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Skriv in ett nytt namn: ");
                    namn[index] = Console.ReadLine();
                    
            
            }
            catch (System.Exception)
            {
                Console.WriteLine("Skriv ett heltal!");
                throw;
            }
            
            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine("Namn: "+namn[i]);
            }
            
        }
    }
}
