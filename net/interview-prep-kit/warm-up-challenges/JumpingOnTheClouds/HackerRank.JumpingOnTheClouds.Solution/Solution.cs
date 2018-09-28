using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.JumpingOnTheClouds.Solution
{
    public class Solution
    {
        private static int CUMULUS = 0;
        private static int THUNDERHEAD = 1;

        public int jumpingOnClouds(int[] c)
        {
            if (c.Length < 2) throw new ArgumentException("Cloud count must be greater than or equal to 2");
            if (c.Length > 100) throw new ArgumentException("Cloud count must be less than or equal to 100");
            if (!Array.TrueForAll(c, cloud => cloud == CUMULUS || cloud == THUNDERHEAD)) throw new ArgumentException("All cloud types should be binary");
            if (c[0] != CUMULUS) throw new ArgumentException("First cloud should be cumulus");
            if (c[c.Length - 1] != CUMULUS) throw new ArgumentException("Last cloud should be cumulus");

            var paths = new List<List<int>>();

            createPath(c, new List<int>() { 0 }, ref paths);
            paths.ForEach(p =>
            {
                var stringPath = string.Join(",", p.Select(x => x.ToString()).ToArray());
                Console.WriteLine($"PATH -> {stringPath}");
            });
            var lengths = paths.Where(p => p.Count > 0).Select(p => p.Count).ToList();

            return lengths.Min() - 1;
        }

        private void createPath(int[] clouds, List<int> path, ref List<List<int>> paths)
        {

            var currentCloudIndex = path[path.Count - 1];
            if (currentCloudIndex == clouds.Length - 1)
            {
                paths.Add(path);
                return;
            }
            else if(currentCloudIndex == clouds.Length - 2){
                path.Add(currentCloudIndex + 1);
                paths.Add(path);
                return;
            }
            var currentCloudType = clouds[currentCloudIndex];
            var oneStepCloseCloud = clouds[currentCloudIndex + 1];
            var twoStepsCloseCloud = clouds[currentCloudIndex + 2];

            if (oneStepCloseCloud == THUNDERHEAD && twoStepsCloseCloud == CUMULUS)
            {
                path.Add(currentCloudIndex + 2);
            }
            else if (oneStepCloseCloud == CUMULUS && twoStepsCloseCloud == THUNDERHEAD)
            {
                path.Add(currentCloudIndex + 1);
            }
            else if (oneStepCloseCloud == CUMULUS && twoStepsCloseCloud == CUMULUS)
            {
                var clonePath = new List<int>(path);

                path.Add(currentCloudIndex + 1);

                clonePath.Add(currentCloudIndex + 2);
                createPath(clouds, clonePath, ref paths);
            }
            createPath(clouds, path, ref paths);
        }
    }
}
