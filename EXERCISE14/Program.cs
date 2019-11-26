using System;

namespace EXERCISE14
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello("Hej på dig");
        }

        static void Hello(string text) 
        {
            //string variabel som indata
           
             Console.WriteLine("Nu skriver vi ut ditt inmatade meddelande tillsammans med en annan text: " + text);
            //Texten skrivs ut tillsammans med ett annat meddelande
        }
    }
}
