/*
* Copyright (C) Jere-Joonas Valtanen
*
* This file is part of JAMK object oriented programming course
*
* Created: 25.1.2016
*Author: Jere-Joonas Valtanen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating player and cpu objects
            Player1 player1 = new Player1();
            Player1 player2 = new Player1();
            CPU_player cpu_player = new CPU_player();
            bool loop = true;
            int input;
            do
            {
                Console.WriteLine("Welcome to dual rock paper scissors");
                Console.WriteLine("1. 2 Player mode");
                Console.WriteLine("2. 1 player VS. CPU");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {

                            // Choosing hands and setting scores to 0

                            player1.Choosehands();
                            player2.Choosehands();
                            player1.Hand1Score = 0;
                            player1.Hand2Score = 0;
                            player2.Hand1Score = 0;
                            player2.Hand2Score = 0;

                            // stupid pile of if words checking which hands win, should've thought of an algorithm or something for this

                            if (player1.Hand1 == player2.Hand1)
                            {
                                player1.Hand1Score = 0;
                                player2.Hand1Score = 0;
                            }
                            else if (player1.Hand1 == 1)
                            {
                                if (player2.Hand1 == 2)
                                    player2.Hand1Score = 1;
                                else player1.Hand1Score = 1;
                            }
                            else if (player1.Hand1 == 2)
                            {
                                if (player2.Hand1 == 3)
                                    player2.Hand1Score = 1;
                                else player1.Hand1Score = 1;
                            }
                            else if (player1.Hand1 == 3)
                            {
                                if (player2.Hand1 == 1)
                                    player2.Hand1Score = 1;
                                else player1.Hand1Score = 1;
                            }



                            if (player1.Hand2 == player2.Hand2)
                            {
                                player1.Hand2Score = 0;
                                player2.Hand2Score = 0;
                            }
                            else if (player1.Hand2 == 1)
                            {
                                if (player2.Hand2 == 2)
                                    player2.Hand2Score = 1;
                                else player1.Hand2Score = 1;
                            }
                            else if (player1.Hand2 == 2)
                            {
                                if (player2.Hand2 == 3)
                                    player2.Hand2Score = 1;
                                else player1.Hand2Score = 1;
                            }
                            else if (player1.Hand2 == 3)
                            {
                                if (player2.Hand2 == 1)
                                    player2.Hand2Score = 1;
                                else player1.Hand2Score = 1;
                            }
                            Console.Clear();

                            // Printing out hand choices

                            Console.WriteLine("Player 1:");
                            player1.Revealhands();
                            Console.WriteLine();
                            Console.WriteLine("Player 2:");
                            player2.Revealhands();

                            // Checking who won

                            if ((player1.Hand1Score + player1.Hand2Score) > (player2.Hand1Score + player2.Hand2Score))
                                Console.WriteLine("Player 1 wins!");
                            else if ((player1.Hand1Score + player1.Hand2Score) < (player2.Hand1Score + player2.Hand2Score))
                                Console.WriteLine("Player 2 wins!");
                            else
                                Console.WriteLine("Tie!");

                            Console.WriteLine();
                            break;
                        }



                    case 2:
                        {
                            // Choosing hands and setting scores to 0

                            player1.Choosehands();
                            cpu_player.CpuHand();
                            player1.Hand1Score = 0;
                            player1.Hand2Score = 0;
                            cpu_player.Hand1Score = 0;
                            cpu_player.Hand2Score = 0;

                            // stupid pile of if words checking which hands win, should've thought of an algorithm or something for this

                            if (player1.Hand1 == cpu_player.Hand1)
                            {
                                player1.Hand1Score = 0;
                                cpu_player.Hand1Score = 0;
                            }
                            else if (player1.Hand1 == 1)
                            {
                                if (cpu_player.Hand1 == 2)
                                    cpu_player.Hand1Score = 1;
                                else player1.Hand1Score = 1;
                            }
                            else if (player1.Hand1 == 2)
                            {
                                if (cpu_player.Hand1 == 3)
                                    cpu_player.Hand1Score = 1;
                                else player1.Hand1Score = 1;
                            }
                            else if (player1.Hand1 == 3)
                            {
                                if (cpu_player.Hand1 == 1)
                                    cpu_player.Hand1Score = 1;
                                else player1.Hand1Score = 1;
                            }



                            if (player1.Hand2 == cpu_player.Hand2)
                            {
                                player1.Hand2Score = 0;
                                cpu_player.Hand2Score = 0;
                            }
                            else if (player1.Hand2 == 1)
                            {
                                if (cpu_player.Hand2 == 2)
                                    cpu_player.Hand2Score = 1;
                                else player1.Hand2Score = 1;
                            }
                            else if (player1.Hand2 == 2)
                            {
                                if (cpu_player.Hand2 == 3)
                                    cpu_player.Hand2Score = 1;
                                else player1.Hand2Score = 1;
                            }
                            else if (player1.Hand2 == 3)
                            {
                                if (cpu_player.Hand2 == 1)
                                    cpu_player.Hand2Score = 1;
                                else player1.Hand2Score = 1;
                            }
                            Console.Clear();

                            // Printing out hand choices

                            Console.WriteLine("Player 1:");
                            player1.Revealhands();
                            Console.WriteLine();
                            Console.WriteLine("CPU :");
                            cpu_player.Revealhands();

                            // Checking for winner

                            if ((player1.Hand1Score + player1.Hand2Score) > (cpu_player.Hand1Score + cpu_player.Hand2Score))
                                Console.WriteLine("Player 1 wins!");
                            else if ((player1.Hand1Score + player1.Hand2Score) < (cpu_player.Hand1Score + cpu_player.Hand2Score))
                                Console.WriteLine("Computer wins!");
                            else
                                Console.WriteLine("Tie!");

                            Console.WriteLine();
                            break;
                        }
                }
            } while (loop == true);
        }
    }
}
