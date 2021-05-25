using PracticeCodes.Models;
using System;
using System.Collections.Generic;

namespace PracticeCodes
{
    public class SnakeLadderProblem
    {
        private readonly int _maxNum;
        public readonly int[] Moves;

        public SnakeLadderProblem(int maxNum)
        {
            _maxNum = maxNum;
            Moves = new int[maxNum];
            for (int i = 0; i < maxNum; i++)
                Moves[i] = i;//-1;
        }

        public int GetMinimumDiceThrows()
        {
            var queueEntries = new Queue<QueueEntry>();
            var visited = new bool[_maxNum];

            var currentQueueEntry = new QueueEntry
            {
                Vertex = 0,
                Distance = 0
            };

            visited[0] = true;
            queueEntries.Enqueue(currentQueueEntry);

            while (queueEntries.Count != 0)
            {
                currentQueueEntry = queueEntries.Dequeue();
                var currentVertex = currentQueueEntry.Vertex;

                Console.Write($"\nCurrent vertex: {currentVertex} => ");

                if (currentVertex == _maxNum - 1)
                    break;

                for (int i = currentVertex + 1; i <= currentVertex + 6 && i < _maxNum; i++)
                {
                    var newVertex = Moves[i];// != -1 ? moves[i] : i;

                    if (!visited[newVertex])
                    {
                        var newEntry = new QueueEntry
                        {
                            Distance = currentQueueEntry.Distance + 1,
                            Vertex = newVertex
                        };

                        visited[newVertex] = true;
                        queueEntries.Enqueue(newEntry);
                        Console.Write($"  {newEntry.Vertex}({newEntry.Distance})  ");
                    }
                }
            }

            return currentQueueEntry.Distance;
        }
    }
}
