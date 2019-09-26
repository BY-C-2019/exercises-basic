using System;

namespace M7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Hallå där ditt fyllo! Här gäller 18år! Hur gammal är du?");
            
            try
            {
                 int inmatning =Convert.ToInt32(Console.ReadLine());

                 if(Myndig(inmatning))
                 {
                        Console.WriteLine("Du är myndig!"); 
                        Console.WriteLine("Välkommen in!");
                 }
                 else
                 {
                            Console.WriteLine("Gå hem med dig snorvalp!");
                 }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Skriv in ett heltal!");
                throw;
            }


        }

        static bool Myndig(int age)
        {
                int myndig=18;
                if(age >=myndig)
                {
                    
                    return true;
                }
                else
                {
                    
                    return false;
                }


        }
    }
}
