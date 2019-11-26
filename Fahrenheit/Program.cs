using System;

namespace Fahrenheit
{
    class Program
    {
        static int CelsiusToFahrenheit(int celsius)
        {
            int fahrenheit = ((celsius * 9) / 5) + 32;
            return fahrenheit;
        }
        static void Main(string[] args)
        {
            Console.Write("Skriv in grader i Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            int fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine(celsius + " grader Celsius blir " + fahrenheit + " grader Fahrenheit. ");
        }
    }
}