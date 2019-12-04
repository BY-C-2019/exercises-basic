using System;
using System.Collections.Generic;

namespace Char
{
    class Program
    {
        static List<int> sifferLista = new List<int>();
        static void Main(string[] args)
        {   string egenSträng="";
            bool loop= true;
            
            while(loop){
            Console.WriteLine("Funktionen leta siffror!\n"+
            "[1]    Skriv in egen sträng\n"+
            "[2]    Leta siffror från färdig sträng\n");
            
            Int32.TryParse(Console.ReadLine(),out int val);

            switch(val)
            {
                    case 1:
                            sifferLista.Clear();
                            Console.WriteLine("Var vänlig mata in din sträng: (Den ska innehålla både siffror och bokstäver)");

                            egenSträng = Console.ReadLine();
                            LetaSiffror(egenSträng);
                        break;
                    case 2:
                        sifferLista.Clear();
                        string färdig = "Detta är en sträng som innehåller siffror typ som 14 5 6 7. Men alla behöver inte ligga i följd utan de kan komm4 lite när som h3lst i text3n";
                        LetaSiffror(färdig);
                        break;
                    case 3:
                            
                        break;
            }
            }
        }
        static void LetaSiffror(string letaSiffra)
        {
            int siffror=0;
            foreach (char item in letaSiffra)
            {
                
                      
                        sifferLista.Add(item);
                        
                        
                            //Console.WriteLine("Siffrorna i leta siffra: "+item);
                        
            }
            foreach (var item in sifferLista)
            {
                if((char)item>='0'&&(char)item<='9')
                {
                    
                    siffror +=(int)item;
                    
                    Console.WriteLine("Siffrorna i strängen är är: "+ (char)item);
                    
                }
                    
                
                
               
            }
                Console.WriteLine(siffror);
        }
    }
}
