﻿using System;

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

            string[] responsToMiss = new string[5];
            string[] responsToHit = new string[5];
            string[] responsToSankShip = new string[5];

            int boardSizeX = 10;
            int boardSizeY = 10;

            int numberOfHits = 0;
            int torpedosUsed = 0;

            int fireCoordinateX = 0;
            int fireCoordinateY = 0;

            char[] interactLine = new char[boardSizeX * 4];
            char[] delimiterLine = new char[boardSizeX * 4];

            bool gameOn = true;

            char hit = '#';
            char miss = '~';
            char ship = '*';
            char torpedoStatus;

            char separatorX = '|';
            char separatorY = '-';

            char[,] ships = new char[boardSizeY, boardSizeX];
            char[,] gameBoard = new char[boardSizeY, boardSizeX];

            Console.WriteLine("To battlestations!");
            Console.WriteLine("It's time for BattleShip!");
            Console.WriteLine("In the Command Line Interface!");
            Console.WriteLine("================================");
            Console.WriteLine("Highscore:");

            // TODO: Add function to exit program.

            // TODO: Select gameboard size.


            do
            {
                Console.Clear();
                // Writes help for symbols.
                Console.WriteLine("=================");
                Console.WriteLine("Hit = '#'");
                Console.WriteLine("Miss = '~'");
                Console.WriteLine("Ship = '*'");
                Console.WriteLine();
                Console.WriteLine("Torpedos used: " + torpedosUsed);
                Console.WriteLine("Number of hits: " + numberOfHits);
                Console.WriteLine();
                // Write out the gameboard.
                // Draw a delimiter --------

                // Keeps track of the interactLine count and index of current
                // value.
                int interactLineCount = 0;
                int interactIndex = 0;
                for (int i = 0; i < (gameBoard.GetLength(0)) * 2; i++)
                {
                    Console.WriteLine();
                    // Resetting interactIndex to 0 for a new interactLine.
                    interactIndex = 0;

                    // varje ojämnt tal är en interactLine
                    if (i % 2 == 1)
                    {
                        // Draw a gameLine

                        for (int j = 0; j <= interactLine.Length; j++)
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
                                    Console.Write(gameBoard[interactLineCount, interactIndex]);
                                    interactIndex++;
                                }
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        interactLineCount++;
                    }
                    // Varje jämnt tal är en delimiterLine
                    else
                    {
                        for (int j = 0; j < delimiterLine.GetLength(0) + 1; j++)
                        {
                            Console.Write(separatorY);
                        }
                    }
                }
                Console.WriteLine();
                for (int j = 0; j < delimiterLine.GetLength(0) + 1; j++)
                {
                    Console.Write(separatorY);
                }

                do
                {
                    // Type in coordinates
                    Console.WriteLine();
                    Console.WriteLine("General! Type in Coordinates for torpedos!");
                    Console.Write("[X]>>");
                    fireCoordinateX = GameInput();
                    Console.Write("[Y]>>");
                    fireCoordinateY = GameInput();
                    Console.Write("Torpedos away! At Coordinates: ");
                    Console.WriteLine(fireCoordinateX + "," + fireCoordinateY);

                    // Is the coordinates valid gameboard values?
                    if (CoordinateValidation(gameBoard, fireCoordinateX, fireCoordinateY))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Those coordinates doesn´t add up!");
                        Console.WriteLine("Try Again");
                    }

                } while (true);

                // Update gameboard.
                if (HitDetection(fireCoordinateX, fireCoordinateY, ships, ship))
                {
                    Console.WriteLine("Excellent commander! Thay never saw it comming!");
                    numberOfHits++;
                    torpedoStatus = hit;
                }
                else
                {
                    Console.WriteLine("What the hell is going on!! Are you blind?!");
                    Console.WriteLine("Fire again God dam it!!");
                    torpedoStatus = miss;
                }
                torpedosUsed++;

                gameBoard = UpdateGameBoard(
                    fireCoordinateX, fireCoordinateY, gameBoard, torpedoStatus);

                Console.ReadKey();
                } while (gameOn);
        }

        public static int GameInput()
        {
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Sir! Thats not the right format for the coordinates!");
                Console.WriteLine("The enemy is getting away! Try again!");
            }

            return input;
        }

        public static bool CoordinateValidation(char[,] gameBoard, int x, int y)
        {
            if (x < gameBoard.GetLength(1) && y < gameBoard.GetLength(0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HitDetection(int x, int y, char[,] ships, char marker)
        {
            if (ships[y, x] == marker)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Ett bra exempel på vart en strukt skulle vara lämplig.
        // Man kan göra parameterlistor mycket kortare!
        public static char[,] UpdateGameBoard(int x, int y, char[,] gameBoard, char marker)
        {
            gameBoard[y, x] = marker;
            return gameBoard;
        }

    }
}
