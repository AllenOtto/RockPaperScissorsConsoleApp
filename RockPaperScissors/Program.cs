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
            string inputPlayer, inputCPU;
            int randomInt;
            Console.Write("Choose between ROCK, PAPER and SCISSORS: ");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);

            switch(randomInt)
            {
                case 1: 

            }
        }
    }
}
