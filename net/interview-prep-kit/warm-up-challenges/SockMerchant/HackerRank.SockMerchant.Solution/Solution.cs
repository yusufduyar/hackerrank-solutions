using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.SockMerchant.Solution
{
    public class Solution
    {
        public int sockMerchant(int numberOfSocks, int[] colorsOfEach)
        {
            if (numberOfSocks != colorsOfEach.Length) throw new ArgumentException("numberOfSockets should equal to colorsOfEach item count");
            var foundPairs = 0;

            var colors = new HashSet<int>();


            for (int i = 0; i < numberOfSocks; i++)
            {
                if (!colors.Contains(colorsOfEach[i]))
                {
                    colors.Add(colorsOfEach[i]);
                }
                else
                {
                    foundPairs++;
                    colors.Remove(colorsOfEach[i]);
                }
            }

            return foundPairs;
        }
    }
}
