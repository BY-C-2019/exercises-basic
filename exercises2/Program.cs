using System;
using System.Threading;

namespace exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            bool run = true;
            while (run)
            {

                try
                {
                    Console.Clear();
                    for (int i = 0; i < name.Length; i++)
                    {
                        Console.Write("\nSkriv in ett namn: ");
                        name[i] = Console.ReadLine();

                    }
                    Console.Clear();
                    Console.WriteLine("\nLaddar.");
                    Thread.Sleep(700);
                    Console.Clear();
                    Console.WriteLine("\nLaddar...");
                    Thread.Sleep(700);
                    Console.Clear();
                    Console.WriteLine("\nLaddar.....");
                    Thread.Sleep(700);
                    Console.Clear();

                    for (int i = 0; i < name.Length; i++)
                    {
                        Console.WriteLine("\n" + "[" + i + "] " + name[i]);
                    }

                    Console.Write("\nByt ut ett namn 0-4: ");
                    string indexInput = Console.ReadLine();
                    string nameInput;
                    if (indexInput == "0")
                    {
                        name[0] = "";
                        Console.WriteLine("\nVilket namn vill du lägga i?: ");
                        nameInput = Console.ReadLine();
                        name[0] = nameInput;

                    }
                    else if (indexInput == "1")
                    {
                        name[1] = "";
                        Console.WriteLine("\nVilket namn vill du lägga i?: ");
                        nameInput = Console.ReadLine();
                        name[1] = nameInput;
                    }
                    else if (indexInput == "2")
                    {
                        name[2] = "";
                        Console.WriteLine("\nVilket namn vill du lägga i?: ");
                        nameInput = Console.ReadLine();
                        name[2] = nameInput;
                    }
                    else if (indexInput == "3")
                    {
                        name[3] = "";
                        Console.WriteLine("\nVilket namn vill du lägga i?: ");
                        nameInput = Console.ReadLine();
                        name[3] = nameInput;
                    }
                    else if (indexInput == "4")
                    {
                        name[4] = "";
                        Console.WriteLine("\nVilket namn vill du lägga i?: ");
                        nameInput = Console.ReadLine();
                        name[4] = nameInput;
                    }
                    Console.Clear();
                    Console.WriteLine("\nLaddar.");
                    Thread.Sleep(700);
                    Console.Clear();
                    Console.WriteLine("\nLaddar...");
                    Thread.Sleep(700);
                    Console.Clear();
                    Console.WriteLine("\nLaddar.....");
                    Thread.Sleep(700);
                    Console.Clear();

                    for (int i = 0; i < name.Length; i++)
                    {
                        Console.WriteLine("\n" + "[" + i + "] " + name[i]);
                    }
                    Console.WriteLine("\nAvsluta med 'q' eller ENTER för att fortsätta..");
                    string quit = Console.ReadLine();
                    if (quit.ToUpper() == "Q")
                    {
                        Console.Clear();
                        Console.WriteLine("\nHejdå!");
                        Thread.Sleep(1500);
                        run = false;
                    }


                }
                catch
                {
                    Console.WriteLine("\noooops... något gick snett....");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
