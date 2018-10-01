using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.MinimumSwaps.Solution
{
    public class Solution
    {
        public int minimumSwaps(int[] arr)
        {
            var arrAsList = arr.ToList();
            var swapCount = 0;

            var currentIndexNumberMap = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                currentIndexNumberMap.Add(arr[i], i);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != i + 1)
                {
                    var indexOfCurrent = currentIndexNumberMap[arr[i]];
                    var otherIndex = currentIndexNumberMap[i + 1];

                    var temp = arr[indexOfCurrent];
                    arr[indexOfCurrent] = arr[otherIndex];
                    arr[otherIndex] = temp;

                    currentIndexNumberMap[i+1] = i;
                    currentIndexNumberMap[temp] = otherIndex;

                    swapCount++;
                }
            }
            return swapCount;
        }

    }
}
