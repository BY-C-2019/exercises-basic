using System;

namespace metoder
{
    class Program
    {
        static string Hello(string input){
            string output = input + " World!";
                
            return output;
        }
        static void Main(string[] args)
        {
            string string1 = Console.ReadLine();
            string outputString = Hello(string1);
            
            Console.WriteLine(outputString);
        }
    }
}
