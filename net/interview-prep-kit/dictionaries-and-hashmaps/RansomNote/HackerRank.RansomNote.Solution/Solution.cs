using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.RansomNote.Solution
{
    public class Solution
    {
        public string checkMagazine(string[] magazine, string[] note)
        {

            Dictionary<string, int> magazineWords = new Dictionary<string, int>();
            foreach (string word in magazine)
            {
                if (magazineWords.ContainsKey(word))
                {
                    magazineWords[word] += 1;
                }
                else
                {
                    magazineWords.Add(word, 1);
                }
            }

            foreach (string word in note)
            {
                int wordCountInMagazine = 0;
                if (magazineWords.TryGetValue(word, out wordCountInMagazine))
                {
                    if (wordCountInMagazine > 1) magazineWords[word] -= 1;
                    else if (wordCountInMagazine == 1) magazineWords.Remove(word);
                }
                else return "No";
            }
            return "Yes";
        }
    }
}
