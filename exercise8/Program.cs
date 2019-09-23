using System;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
