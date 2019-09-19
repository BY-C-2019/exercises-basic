using System;

namespace excerise5
{
    class Program
    {
            static double AddMoms(double sumBeforeMoms, double momsSatsen)
        {
            double moms = (momsSatsen / 100.0) +1.0;
            double finalSum = sumBeforeMoms * moms;
            return finalSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
