using System;

namespace HackerRank.CountingValleys.Solution
{
    public class Solution
    {
                public int countValleys(int totalSteps, string path)
        {
            if (totalSteps != path.Length) throw new ArgumentException("totalSteps should be equal to path length");

            var totalValleyCount = 0;
            var heightFromSea = 0;

            var garyIsInValley = false;

            for (int i = 0; i < totalSteps; i++)
            {
                if (path[i] == 'D') heightFromSea -= 1;
                else if (path[i] == 'U') heightFromSea += 1;

                if (heightFromSea == -1) garyIsInValley = true;
                if (heightFromSea == 0 && garyIsInValley)
                {
                    totalValleyCount += 1;
                    garyIsInValley = false;
                }
            }

            return totalValleyCount;
        }
    }
}
