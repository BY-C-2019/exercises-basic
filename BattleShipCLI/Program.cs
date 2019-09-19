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
        *       
        */







        static void Main(string[] args)
        {
            int boardSizeX = 10;
            int boardSizey = 10;

            char[,] gameBoard = new char[,]


            Console.WriteLine("All personell to battlestation!");
            Console.WriteLine("It's time for BattleShip!");
            Console.WriteLine("In the Command Line Interface!");
            Console.WriteLine("================================");

        }
    }
}
