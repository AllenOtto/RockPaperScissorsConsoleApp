using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare your variables
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;
            int scorePlayer = 0;
            int scoreCPU = 0;

            
            
            while(playAgain)
            {
                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    // Get user choice
                    Console.Write(" \nChoose between ROCK, PAPER and SCISSORS: \n\n ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    // Get computer choice
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    // Compare choices and display result
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose 'ROCK'");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("You also chose 'ROCK'. It's a DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("You chose 'PAPER'. 'PAPER' beats 'ROCK'. You WIN!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("You chose 'SCISSORS'. 'ROCK' beats 'SCISSORS'. Computer WINS!!\n\n");
                                scoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("Error 1: Under computer choice ROCK\n\n");
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.Write("Computer chose 'PAPER'\n\n");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("You also chose 'PAPER'. It's a DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("'PAPER' beats 'ROCK'. Computer WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("'SCISSORS' cut 'PAPER'. You WIN!!\n\n");
                                scorePlayer++;
                            }
                            else
                            {
                                Console.WriteLine("Error 2: Under computer choice: PAPER\n\n");
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer Chose 'SCISSORS'\n\n");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("You also chose 'SCISSORS'. It's a draw!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("'ROCK' trumples 'SCISSORS'. You WIN!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("'SCISSORS' cut 'PAPER'. Computer WINS!!\n\n");
                                scoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("Error 3: Under computer choice SCISSORS\n\n");
                            }
                            break;
                        default:

                            break;
                    }
                }

                // Delare winner
                if (scorePlayer == 3)
                {
                    Console.WriteLine("\n\nCongrats!! You WIN. \n\n");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine(" \n\nBoohoo!! You Lost. \n\n");
                }
                else
                {
                    //
                }

                // Ask if player wants to have at it again
                Console.Write("Play again? (Hit y to continue and anything else to exit) ");
                string loop = Console.ReadLine();
                loop = loop.ToLower();

                if (loop == "y")
                {
                    scoreCPU = 0;
                    scorePlayer = 0;
                    playAgain = true;
                } else
                {
                    playAgain = false;
                }

            }
        }
    }
}
