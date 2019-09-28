using System;
using System.Globalization;

namespace exercise21
{
    class Program
    {

        static void Main(string[] args)
        {


            bool run = true;
            while (run)
            {
                var format = new NumberFormatInfo();
                format.NegativeSign = "-";
                Console.WriteLine("\n[MatteProgram]");
                Console.WriteLine("\n");
                Console.WriteLine("\n[1]. Pythagoras sats" +
                "\n[2]. Omkretsen på en cirkel" +
                "\n[3]. Arean på en cirkel" +
                "\n[4]. Volymen i en kub" +
                "\n[5]. Volymen i en cylinder" +
                "\n[6]. Volymen i en kon" +
                "\n[7]. Pq-formeln" +
                "\n[8]. Miniräknare");
                Console.WriteLine("\n");
                Console.Write("Ditt val: ");

                int userInput1;
                int userInput2;

                try
                {
                    userInput1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    userInput1 = -1;
                }

                switch (userInput1)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n[Pythagoras sats]");

                        Console.Write("\nSkriv in höjden: ");
                        double.TryParse(Console.ReadLine(), out double a);
                        Console.WriteLine("\nSkriv in basen: ");
                        double.TryParse(Console.ReadLine(), out double b);

                        double c = Pythagoras(a, b);
                        Console.WriteLine("\nHypotenusan är: " + c + " lång.");
                        Enter();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n[Omkretsen på en cirkel]");

                        Console.Write("\nSkriv in cirkelns radie: ");
                        double.TryParse(Console.ReadLine(), out double radie);
                        Console.WriteLine("\nCirkelns radie är: " + CirkelOmkrets(radie));
                        Enter();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n[Arean på en cirkel]");

                        Console.Write("\nSkriv in cirkelns radie: ");
                        double.TryParse(Console.ReadLine(), out double s);
                        Console.WriteLine("\nCirkelns area är: " + CirkelArea(s));
                        Enter();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n[Volymen i en kub]");

                        Console.Write("\nSkriv in Kubens ena sida: ");
                        double.TryParse(Console.ReadLine(), out double sida);
                        Console.WriteLine("\nKubens volym är: " + KubVolym(sida));
                        Enter();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n[Volymen i en cylinder]");

                        Console.Write("\nSkriv in bascirkelns radie: ");
                        double.TryParse(Console.ReadLine(), out double e);
                        Console.Write("\nSkriv in cylinderns höjd: ");
                        double.TryParse(Console.ReadLine(), out double f);
                        Console.WriteLine("\nVolymen i cylindern är: " + CylinderVolym(e, f));
                        Enter();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n[Volymen i en kon]");

                        Console.Write("\nSkriv in konens radie: ");
                        double.TryParse(Console.ReadLine(), out double r);
                        Console.Write("\nSkriv in Cylinderns höjd: ");
                        double.TryParse(Console.ReadLine(), out double h);
                        Console.WriteLine("\nVolymen i konen är: " + KonVolym(r, h));
                        Enter();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("\n[Pq-Formeln]");

                        Console.Write("\nSkriv in ett värde på 'p': ");
                        double p = double.Parse(Console.ReadLine(),format);
                        Console.Write("\nSkriv in ett värde på 'q': ");
                        double q = double.Parse(Console.ReadLine(),format);

                        Console.WriteLine(Pqformel(p, q));
                        Enter();
                        break;
                    case 8:
                        bool running = true;
                        while (running)
                        {
                            Console.Clear();
                            Console.WriteLine("\n[Miniräknaren]");
                            Console.WriteLine("\n");
                            Console.WriteLine("\n[1]. Starta miniräknaren" +
                            "\n[2]. Avsluta ");
                            Console.Write("\nDitt val: ");

                            try
                            {
                                userInput2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                userInput2 = -1;
                            }

                            switch (userInput2)
                            {
                                case 1:
                                    Console.Write("\nSkriv in ett nummer: ");
                                    double.TryParse(Console.ReadLine(), out double num1);
                                    Console.WriteLine("\nSkriv in ditt andra nummer: ");
                                    double.TryParse(Console.ReadLine(), out double num2);

                                    double answer1 = num1 + num2;
                                    double answer2 = num1 - num2;
                                    double answer3 = num1 * num2;
                                    double answer4 = num1 / num2;
                                    double answer5 = Math.Pow(num1, num2);

                                    Console.WriteLine("\n +: " + answer1 +
                                    "\n -: " + answer2 +
                                    "\n *: " + answer3 +
                                    "\n /: " + answer4 +
                                    "\n ^: " + answer5 +
                                    "\nroten ur *: " + Math.Sqrt(answer3) +
                                    "\nroten ur ^: " + Math.Sqrt(answer5));
                                    Enter();
                                    break;
                                case 2:
                                    running = false;
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("\nOgiltigt värde..");
                                    Enter();
                                    break;
                            }

                        }
                        break;

                    default:
                        Console.WriteLine("\nOgiltigt värde..");
                        Enter();
                        break;

                }


            }

        }
        static double Pythagoras(double a, double b)
        {
            double c2 = (a * a) + (b * b);
            double c = Math.Sqrt(c2);
            return c;
        }
        static double CirkelOmkrets(double radie)
        {
            double co = radie * 2 * Math.PI;
            return co;
        }
        static double CirkelArea(double s)
        {
            double ca = Math.PI * Math.Pow(s, 2);
            return ca;
        }
        static double KubVolym(double sida)
        {
            double kb = Math.Pow(sida, 3);
            return kb;
        }
        static double CylinderVolym(double e, double f)
        {
            double cv = Math.Pow(e, 2) * Math.PI * f;
            return cv;
        }
        static double KonVolym(double r, double h)
        {
            double k = Math.PI * Math.Pow(r, 2) * h / 3;
            return k;
        }
        static string Pqformel(double p, double q)
        {
            double x1 = -(p / 2) + Math.Sqrt(Math.Pow((p / 2), 2) - q);
            double x2 = -(p / 2) - Math.Sqrt(Math.Pow((p / 2), 2) - q);
            return "\nEkvationens rötter är: " + x1 + " och " + x2;

        }
        static void Enter()
        {
            Console.WriteLine("\nTryck ENTER för att fortsätta...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
