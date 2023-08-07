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
            int scorePlayer = 0;
            int scoreCPU = 0;

            // Get user choice
            Console.Write("Choose between ROCK, PAPER and SCISSORS: ");
            inputPlayer = Console.ReadLine();

            // Get compuer choice
            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);
            
            // Compare choices and display result
            switch(randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose 'ROCK'");
                    if(inputPlayer == "ROCK")
                    {
                        Console.WriteLine("You also chose 'ROCK'. It's a DRAW!!");
                    }
                    else if(inputPlayer == "PAPER")
                    {
                        Console.WriteLine("You chose 'PAPER'. 'PAPER' beats 'ROCK'. You WIN!!");
                    }
                    else if(inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("You chose 'SCISSORS'. 'ROCK' beats 'SCISSORS'. Computer WINS!!");
                    }
                    else
                    {
                        Console.WriteLine("Error 1: Under computer choice ROCK");
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.Write("Computer chose 'PAPER'");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("You also chose 'PAPER'. It's a DRAW!!");
                    }
                    else if(inputPlayer == "ROCK")
                    {
                        Console.WriteLine("'PAPER' beats 'ROCK'. Computer WINS!!");
                    }
                    else if( inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("'SCISSORS' cut 'PAPER'. You WIN!!");
                    }
                    else
                    {
                        Console.WriteLine("Error 2: Under computer choice: PAPER");
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer Chose 'SCISSORS'");
                    if(inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("You also chose 'SCISSORS'. It's a draw!");
                    }
                    else if(inputPlayer == "ROCK")
                    {
                        Console.WriteLine("'ROCK' trumps 'SCISSORS'. You WIN!");
                    }
                    else if(inputPlayer == "PAPER")
                    {
                        Console.WriteLine("'SCISSORS' cut 'PAPER'. Computer WINS!!");
                    }
                    else
                    {
                        Console.WriteLine("Error 3: Under computer choice SCISSORS");
                    }
                    break;
                default:
                    
                    break;
            }
        }
    }
}
