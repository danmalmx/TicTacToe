using System;

namespace TicTacToe
{
    class MainClass
    {

        static 
        public void Main(string[] args)
        {


            int[,] ticTacToeGrid =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9},
            };

            int positionOne = ticTacToeGrid[0, 0];
            int positionTwo = ticTacToeGrid[0, 1];
            int positionThree = ticTacToeGrid[0, 2];
            int positionFour = ticTacToeGrid[1, 0];
            int positionFive = ticTacToeGrid[1, 1];
            int positionSix = ticTacToeGrid[1, 2];
            int positionSeven = ticTacToeGrid[2, 0]; 
            int positionEight = ticTacToeGrid[2, 1];
            int positionNine = ticTacToeGrid[2, 2];

            Console.Write("   |   |   |");
            Console.WriteLine("");
            Console.WriteLine(" {0} | {1} | {2} |", positionOne, positionTwo, positionThree);
            Console.WriteLine("___|___|___|");
            Console.WriteLine("   |   |   |");
            Console.WriteLine(" {0} | {1} | {2} |", positionFour, positionFive, positionSix);
            Console.WriteLine("___|___|___|");
            Console.WriteLine("   |   |   |");
            Console.WriteLine(" {0} | {1} | {2} |", positionSeven, positionEight, positionNine);
            Console.WriteLine("___|___|___|");

        }
    }
}