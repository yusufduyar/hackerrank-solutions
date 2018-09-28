using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.TwoDimensionsArray.Solution
{
    public class Solution
    {
        public int hourglassSum(int[,] arr)
        {
                      var sums = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for(int j=0; j<4; j++){
                    sums.Add(arr[i,j] + arr[i,j+1] + arr[i,j+2]
                    + arr[i+1,j+1] + arr[i+2,j] + arr[i+2,j+1]
                    + arr[i+2,j+2]);
                }
            }

            return sums.Max();
        }

    }
}
