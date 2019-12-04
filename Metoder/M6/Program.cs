using System;

namespace M6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in ett decimaltal");
            try
            {
                double inmatning= Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Decimaltalet bilr "+ToPercentage(inmatning)+" avrundat till heltal");

            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        static int ToPercentage(double inmatning)
        {   int utmatning=0;

            utmatning = Convert.ToInt32(Math.Round(inmatning));
            return utmatning;
        }
    }
}
