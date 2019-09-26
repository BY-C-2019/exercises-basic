using System;

namespace M8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool avsluta= true;
            while(avsluta){
                Console.Clear();
                Console.WriteLine("Välkommen till denna meny!\n"+
                "Var vänlig gör ditt val!\n"+
                "[1]    Addera\n"+
                "[2]    Subtrahera\n"+
                "[3]    Multiplicera\n"+
                "[4]    Dividera\n"+
                "[5]    Avsluta");
                try
                {
                
                   int inmatning= Convert.ToInt32(Console.ReadLine());
                   
                   

                   switch(inmatning)
                {
                    case 1:
                           
                                Console.WriteLine("Summan blir. "+ Addera()+".");
                                Console.ReadLine();
                
                        break;
                    case 2:
                                Console.WriteLine("Summan blir. "+ Subtrahera()+".");
                                Console.ReadLine();
                        break;
                    case 3:
                                Console.WriteLine("Summan blir. "+ Multiplicera()+".");
                                Console.ReadLine();
                        break;
                    case 4:
                                Console.WriteLine("Summan blir. "+ Dividera()+".");
                                Console.ReadLine();
                        break;
                }
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Du måste skriva ett heltal!");
                    throw;
                }
                

            }
        }


        static double Addera()
        {   double summa=0;
            Console.Write("Skriv in tal ett: ");

            if(Double.TryParse(Console.ReadLine(),out double inmatningEtt))
            {
                    Console.Write("Skriv in tal två: ");
            }
            else
            {
                return summa;
            }
            if(Double.TryParse(Console.ReadLine(),out double inmatningTvå))
            {
                
                summa = inmatningEtt + inmatningTvå;
                return summa;   
            }
            else
            {
                return summa ;
            }
           
            
          
        }
        static double Subtrahera()
        {   double summa=0;
            Console.Write("Skriv in tal ett: ");

            if(Double.TryParse(Console.ReadLine(),out double inmatningEtt))
            {
                    Console.Write("Skriv in tal två: ");
            }
            else
            {
                return summa;
            }
            if(Double.TryParse(Console.ReadLine(),out double inmatningTvå))
            {
                
                summa = inmatningEtt -inmatningTvå;
                return summa;   
            }
            else
            {
                return summa ;
            }
           
            
          
        }
        static double Multiplicera()
        {   double summa=0;
            Console.Write("Skriv in tal ett: ");

            if(Double.TryParse(Console.ReadLine(),out double inmatningEtt))
            {
                    Console.Write("Skriv in tal två: ");
            }
            else
            {
                return summa;
            }
            if(Double.TryParse(Console.ReadLine(),out double inmatningTvå))
            {
                
                summa = inmatningEtt * inmatningTvå;
                return summa;   
            }
            else
            {
                return summa ;
            }
           
            
          
        }
        static double Dividera()
        {   double summa=0;
            Console.Write("Skriv in tal ett: ");

            if(Double.TryParse(Console.ReadLine(),out double inmatningEtt))
            {
                    Console.Write("Skriv in tal två: ");
            }
            else
            {
                return summa;
            }
            if(Double.TryParse(Console.ReadLine(),out double inmatningTvå))
            {
                
                summa = inmatningEtt / inmatningTvå;
                return summa;   
            }
            else
            {
                return summa ;
            }
           
            
          
        }
       
    }
}
