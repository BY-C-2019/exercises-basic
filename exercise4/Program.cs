using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = GetUnicodeCharacter();
            foreach (var item in symbols)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();        
        }

        public static char[] GetUnicodeCharacter()
        {
            char[] symbols = new char[]
            {
                '\u0026',
                '\u0029',
                '\u0600',
                '\u0603'
            };
            return symbols;
        }
    }
}
