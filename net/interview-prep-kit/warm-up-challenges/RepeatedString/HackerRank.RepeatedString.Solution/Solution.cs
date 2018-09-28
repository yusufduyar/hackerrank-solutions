using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.RepeatedString.Solution
{
    public class Solution
    {
                public long repeatedString(string s, long n)
        {
            if(s.Count()>n)
                return s.Substring(0,(int)n).Count(x=>x== 'a');
                
            var aCountInBaseString = s.Count(x=> x == 'a');
            var baseStringRepeatCount = n/s.Count();
            
            var aCountInRemainingPart = 0;
            var remainder = n % baseStringRepeatCount;

            if(remainder != 0){
                var remainingPart =  s.Substring(0,(int)remainder);
                aCountInRemainingPart = remainingPart.Count(x=> x == 'a');
            }

            var aTotalCount = (aCountInBaseString * baseStringRepeatCount) + aCountInRemainingPart;

            return aTotalCount;
        }
    }
}
