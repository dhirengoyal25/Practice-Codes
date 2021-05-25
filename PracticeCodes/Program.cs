using System;

namespace PracticeCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //SnakeAndLadderProblem();
            LargestContiguousSubArraySum();
            Console.ReadLine();
        }

        private static void SnakeAndLadderProblem()
        {
            var snakeLadderProblem = new SnakeLadderProblem(30)
            {
                Moves =
                {
                    // Ladders
                    [2] = 21,
                    [4] = 7,
                    [10] = 25,
                    [19] = 28,
                    // Snakes
                    [26] = 0,
                    [20] = 8,
                    [16] = 3,
                    [18] = 6
                }
            };

            Console.WriteLine($"Min Dice throws required is {snakeLadderProblem.GetMinimumDiceThrows()}");
        }

        private static void LargestContiguousSubArraySum()
        {
            int[] inputNums = { -2, -3, 4, -1, -2, 1, 5, -3 };

            var largestContiguousSubArray = new LargestContiguousSubArray(inputNums);
            Console.WriteLine($"Largest Sum: {largestContiguousSubArray.GetLargestContiguousSum()}");
        }
    }
}
