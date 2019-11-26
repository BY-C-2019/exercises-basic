using System;

namespace EXCERCISE20
{
    class Program
    {
        static bool Myndig(int age)
        {
            bool a = false;

            if (age >= 18)
            {
                return true;
            }
            if (age < 18)
            {
                return false;
            } 
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, Vi vill kontrollera om du är myndig. Ange din ålder här:");
            int age = Convert.ToInt32(Console.ReadLine());
            bool myndig = Myndig(age);
            Console.WriteLine(myndig);
        }
    }
}
