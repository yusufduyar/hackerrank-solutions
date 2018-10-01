using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.LeftRotation.Solution
{
    public class Solution
    {
        public int[] rotLeft(int[] numbers, int rotationCount)
        {
            var arrayLength = numbers.Length;
            var rotatedArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                var newIndex = i - rotationCount >= 0 ? i-rotationCount : i-rotationCount+arrayLength;
                rotatedArray[newIndex] = numbers[i];
            }

            return rotatedArray;
        }
    }
}
