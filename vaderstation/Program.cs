using System;
using System.Collections.Generic;
using System.Threading;

namespace vaderstation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> temps = new List<int>();
            bool run = true;

            try
            {
                while (run)
                {
                    
                    Console.WriteLine("[Väderstationen]");
                    Console.WriteLine("\n");
                    Console.WriteLine("[1]. Lägg till mätning" +
                    "\n[2]. Skriv ut mätningar" +
                    "\n[3]. Byt ut en mätning");
                    Console.Write("\nDitt val: ");
                    string userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                        Console.Clear();
                            Console.Write("Hur många mätningar vill du göra?: ");
                            int userInput2 = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < userInput2; i++)
                            {
                                Console.Write("Din mätning: ");
                                temps.Add(Convert.ToInt32(Console.ReadLine()));
                            }
                            Loading();

                            break;
                        case "2":
                        Console.Clear();
                            Loading();
                            Console.WriteLine("Dina Mätningar: ");
                            foreach (var item in temps)
                            {
                                Console.WriteLine(item);
                            }
                            int medelVarde = 0;
                            for (int i = 0; i < temps.Count; i++)
                            {
                                medelVarde += temps[i];
                            }
                            medelVarde = medelVarde / temps.Count;
                            Console.WriteLine("Medelvärdet: " + medelVarde);
                            Thread.Sleep(1500);
                            break;
                        case "3":
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Vilken mätning vill du ta bort?");
                                Console.Write("\nDitt val: ");
                                int userInput3 = Convert.ToInt32(Console.ReadLine());
                                Loading();
                                temps.RemoveAt(userInput3);


                            }
                            catch
                            {
                                Console.WriteLine("indexet finns inte i listan..");
                            }


                            break;
                        default:
                            break;
                    }
                }

            }
            catch
            {
                Console.WriteLine("Ogiltigt värde...");
            }
        }
        static void Loading()
        {
            Console.WriteLine("Laddar.");
            Thread.Sleep(650);
            Console.WriteLine("Laddar...");
            Thread.Sleep(650);
            Console.WriteLine("Laddar.....");
            Thread.Sleep(650);
        }
    }
}
