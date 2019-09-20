<<<<<<< HEAD
﻿using System;

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
=======
﻿using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.Write("Ange ett decimaltal:");
				string input = Console.ReadLine();
				double value = Convert.ToDouble(input);
				int closestInt = (int)Math.Round(value);
				Console.WriteLine("Närmaste heltalet var: " + closestInt);
			}
			catch
			{
				Console.WriteLine("Snälla, du vet ju hur ett decimaltal ser ut 🤦‍");
			}
        }
    }
}
>>>>>>> 8e915dc981df3518f34687667145ecb82ac90349
