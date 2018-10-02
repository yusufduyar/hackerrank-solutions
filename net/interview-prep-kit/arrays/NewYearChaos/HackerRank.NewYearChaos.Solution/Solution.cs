using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.NewYearChaos.Solution
{
    public class Solution
    {
        public string minimumBribes(int[] q)
        {
            var currentIndexQueueMap = new Dictionary<int, int>();
            var tooChaotic = false;
            var totalIndexChanges = 0;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    tooChaotic = true;
                }
                for (int j = q[i] - 2 > 0 ? q[i] - 2 : 0; j < i; j++)
                    if (q[j] > q[i]) totalIndexChanges++;
            }
            if (tooChaotic) return "Too chaotic";
            else return (totalIndexChanges).ToString();
        }
    }
}
