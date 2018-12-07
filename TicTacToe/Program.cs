using System;

namespace TicTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] ticTacToeGrid =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };

            Console.Write("   |   |   |");
            Console.WriteLine("");
            Console.WriteLine(" {0} | {1} | {2} |", ticTacToeGrid[0, 0], ticTacToeGrid[0, 1], ticTacToeGrid[0, 2]);
            Console.WriteLine("___|___|___|");
            Console.WriteLine("   |   |   |");
            Console.WriteLine(" {0} | {1} | {2} |", ticTacToeGrid[1, 0], ticTacToeGrid[1, 1], ticTacToeGrid[1, 2]);
            Console.WriteLine("___|___|___|");
            Console.WriteLine("   |   |   |");
            Console.WriteLine(" {0} | {1} | {2} |", ticTacToeGrid[2, 0], ticTacToeGrid[2, 1], ticTacToeGrid[2, 2]);
            Console.WriteLine("___|___|___|");

        }
    }
}