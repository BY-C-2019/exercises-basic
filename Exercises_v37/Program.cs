using System;

namespace Exercises_v37
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            Program prog = new Program();
            string[] menuItems = new string[]{
                "Sum Two Integers",
                "Roundup a decimal number",
                "Write a story",
                "Print some unicode",
                "Retail Manager",
                "Backpack Simulator"
            };

            bool closeApp = true;
            int menuChoice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine(">>>>> En massa enkla metoder >>>>>");
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.Write((i + 1) + ": ");
                    System.Console.WriteLine(menuItems[i]);
                }
                Console.Write("Select Function[1 - 5]: ");
                try
                {
                    menuChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Not a valid input");
                    Console.WriteLine(e);
                    continue;
                }

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Sum of Two Integers");
                        Console.Write("First Integer: ");
                        int integerOne = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Second Integer: ");
                        int integerTwo = Convert.ToInt32(Console.ReadLine());
                        int result = SumTwoInteger(integerOne, integerTwo);
                        Console.WriteLine("Result: " + result);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Enter a decimal number to roundup: ");
                        double decimalNumber = Convert.ToDouble(Console.ReadLine());
                        int newNumber = RoundupInteger(decimalNumber);
                        Console.WriteLine(newNumber);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Second Name: ");
                        string secondName = Console.ReadLine();
                        Console.WriteLine(
                            StoryFromNames(firstName, secondName));
                        Console.ReadKey();
                        break;

                    case 4:
                        char[] symbols = GetUnicodeCharacter();
                        foreach (var item in symbols)
                        {
                            Console.WriteLine(item);
                        }
                        Console.ReadKey();
                        break;

                    case 5:
                        Bank();
                        break;

                    case 6:
                        Backpack();
                        break;

                    case 0:
                        closeApp = false;
                        break;

                    default:
                        Console.WriteLine("Non valid entry");
                        Console.WriteLine("Exiting...");
                        Console.ReadKey();
                        closeApp = false;
                        break;
                }
            } while (closeApp);
        }



        public static int SumTwoInteger(int NumberOne, int numberTwo)
        {
            int result;
            result = NumberOne + numberTwo;
            return result;
        }

        public static int RoundupInteger(double decimalNumber)
        {
            int result = Convert.ToInt32(decimalNumber);
            return result;
        }

        public static string StoryFromNames(string firstName, string secondName)
        {
            string story = firstName;
            story += " went for a walk with ";
            story += secondName;

            return story;
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

        public static void Bank()
        {
            int saldo = 100;
            bool bankClosed = false;
            do
            {
                Console.WriteLine("<<<<< Bank Simulator >>>>>");
                Console.WriteLine("\n[1]Withdrawel");
                Console.WriteLine("\n[2]Inset");
                Console.WriteLine("\n[3]Check Balance");
                Console.Write(">>");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Amount: ");
                        int withdrawel = Convert.ToInt32(Console.ReadLine());
                        if (withdrawel <= saldo)
                        {
                            saldo -= withdrawel;
                            Console.WriteLine("You have " + saldo + " left on account.");
                        }
                        else
                        {
                            Console.WriteLine("Balance out o limit!");
                            Console.WriteLine("Select a smaller amount.");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Amount to add: ");
                        saldo += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Balance updated.");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Your balance is: " + saldo);
                        Console.ReadKey();
                        break;
                    
                    default:
                        bankClosed = true;
                        break;
                }
            } while (!bankClosed);

        }

        public static void Backpack()
        {
            string content = "";
            do
            {

                Console.WriteLine("<<<< Ryggsäcken >>>>");
                Console.WriteLine("\n[1]Lägg till föremål");
                Console.WriteLine("[2]Töm ryggsäcken");
                Console.WriteLine("[3]Visa innehåll");
                Console.WriteLine("[4]Avsluta");
                Console.Write(">>");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Lägg till föremål: ");
                        content += " | ";
                        content += Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Tömmer ryggsäcken...");
                        content = "";
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ryggsäckens innehåll:");
                        Console.WriteLine(content);
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
            } while (true);
        }
        }
    }
}
