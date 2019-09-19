using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double decimalNumber = 0;
            int integer = 0;
            Console.Write(">>");
            try
            {
                decimalNumber = Convert.ToDouble(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Oppss! Ett fel inträffade!");
                Console.WriteLine("Felmeddelande: " + e);
            }

            integer = Convert.ToInt32(decimalNumber);


            Console.WriteLine("Decimaltal är: " + decimalNumber);
            Console.WriteLine("Avrundat tal är: " + integer);
            Console.ReadKey();
        }
    }
}
