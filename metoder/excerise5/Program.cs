using System;

namespace excerise5
{
    class Program
    {
            static double AddMoms(double sumBeforeMoms, int momsSatsen)
        {
            double moms = (momsSatsen / 100) +1;
            return sumBeforeMoms * moms;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
