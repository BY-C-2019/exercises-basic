using System;

namespace BattleShipCLI
{
    class Program
    {
        // /* GameBoard layout:
        // *         0   1   2   3   4   5
        // *   >   -------------------------
        // *   0   | * |   |   |   | # |   |
        // *   >   -------------------------
        // *   1   | * |   |   |   | # |   |
        // *   >   -------------------------
        // *   2   |   |   |   |   | # |   |
        // *   >   -------------------------
        // *   3   |   |   | * | * | * |   |
        // *   >   -------------------------
        // *   4   |   | ~ |   |   |   |   |
        // *   >   -------------------------
        // *   5   |   |   |   |   |   |   |
        // *   >   -------------------------
        // *
        // *       Hit = #
        // *       Miss = ~
        // *       Ship = *
        // *       
        // */







        static void Main(string[] args)
        {
            int boardSizeX = 10;
            int boardSizeY = 10;

            char hit = '#';
            char miss = '~';
            char ship = '*';
            

            char[,] gameBoard = new char[boardSizeY, boardSizeX];

            // For every row in 


            Console.WriteLine("All personell to battlestation!");
            Console.WriteLine("It's time for BattleShip!");
            Console.WriteLine("In the Command Line Interface!");
            Console.WriteLine("================================");

        }
    }
}
