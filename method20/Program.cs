using System;

namespace exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din ålder: ");
            int age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Age(age1));

        }
        static bool Age(int age)
        {
            Convert.ToBoolean(age);
            if (age >= 18)
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