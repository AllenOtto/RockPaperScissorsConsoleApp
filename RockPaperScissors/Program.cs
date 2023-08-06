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
                    Console.Write("Computer chose 'ROCK'");
                    if(inputPlayer == "ROCK")
                    {
                        Console.Write("You also chose 'ROCK'. It's a DRAW!!");
                    }
                    else if(inputPlayer == "PAPER")
                    {
                        Console.Write("You chose 'PAPER'. 'PAPER' beats 'ROCK'. You WIN!!");
                    }
                    else if(inputPlayer == "SCISSORS")
                    {
                        Console.Write("You chose 'SCISSORS'. 'ROCK' beats 'SCISSORS'. Computer WINS!!");
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.Write("Computer chose 'PAPER'");
                    if (inputPlayer == "PAPER")
                    {
                        Console.Write("You also chose 'PAPER'. It's a DRAW!!");
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    break;
                default:
                    
                    break;
            }
        }
    }
}
