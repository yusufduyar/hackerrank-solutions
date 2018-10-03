using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.ArrayManipulation.Solution
{
    public class NumberFrequencyMap
    {
        public int Number { get; set; }
        public int Frequency { get; set; }
        public int TotalValue { get; set; }
    }
    public class Solution
    {
        public long arrayManipulation(int numberOfElements, int[][] queries)
        {
            var queryCount = queries.GetLength(0);
            var totals = new long[numberOfElements + 1];

            for (long i = 0; i < queryCount; i++)
            {
                var leftIndex = queries[i][0];
                var rightIndex = queries[i][1];
                var summand = queries[i][2];

                totals[leftIndex] += summand;
                if (rightIndex + 1 <= numberOfElements)
                {
                    totals[rightIndex + 1] -= summand;
                }
            }
            long tempMax = 0;
            long max = 0;
            for (long i = 0; i <= numberOfElements; i++)
            {
                tempMax += totals[i];
                if(tempMax >max) max = tempMax;
            }
            return max;
        }
    }
}
