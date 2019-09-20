using System;

namespace BattleShipCLI
{
    class Program
    {
        /* GameBoard layout:
        *         0   1   2   3   4   5
        *   >   -------------------------
        *   0   | * |   |   |   | # |   |
        *   >   -------------------------
        *   1   | * |   |   |   | # |   |
        *   >   -------------------------
        *   2   |   |   |   |   | # |   |
        *   >   -------------------------
        *   3   |   |   | * | * | * |   |
        *   >   -------------------------
        *   4   |   | ~ |   |   |   |   |
        *   >   -------------------------
        *   5   |   |   |   |   |   |   |
        *   >   -------------------------
        *
        *       Hit = #
        *       Miss = ~
        *       Ship = *
        *       
        */


        static void Main(string[] args)
        {

            int boardSizeX = 10;
            int boardSizeY = 10;

            char[] interactIndex = new char[boardSizeX];

            char[] interactLine = new char[boardSizeX * 4];
            char[] delimiterLine = new char[boardSizeX * 4];

            bool gameOn = true;

            char hit = '#';
            char miss = '~';
            char ship = '*';

            char separatorX = '|';
            char separatorY = '-';



            char[,] gameBoard = new char[boardSizeY, boardSizeX];

            // For every row in 


            Console.WriteLine("All personell to battlestation!");
            Console.WriteLine("It's time for BattleShip!");
            Console.WriteLine("In the Command Line Interface!");
            Console.WriteLine("================================");

            // Select gameboard size.


            do
            {
                // Write out the gameboard.
                // Draw a delimiter --------
                for (int i = 0; i < gameBoard.GetLength(0) + 1; i++)
                {
                    Console.WriteLine();
                    if (i % 2 == 1)
                    {
                        // Draw a gameLine
                        for (int j = 0; j < interactLine.Length + 1; j++)
                        {
                            // Kollar vart annat element för antingen interagera
                            // eller avskiljning.
                            if (j % 2 == 0)
                            {
                                // Var fjärde element ska vara en avskiljare
                                if (j % 4 == 0)
                                {
                                    Console.Write(separatorX);
                                }
                                else
                                {
                                    // Kontrollera om där finns något från
                                    // inteactIndex.
                                    //if (interactIndex[j])
                                    Console.Write(" ");
                                }
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        
                    }
                    else
                    {
                        for (int j = 0; j < delimiterLine.GetLength(0) + 1; j++)
                        {
                            Console.Write(separatorY);
                        }
                    }


                }


                // Type in coordinates


                // Update gameboard.

                Console.ReadKey();



            } while (gameOn);

        }

    }
}
