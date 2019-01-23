using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode771JewelsAndStones
{
    public class Solution
    {
        public int NumJewelsInStones(string J, string S)
        {
            int count = 0;
            var js = J.ToArray();

            var ss = S.ToArray();

            foreach (var j in js)
            {
                foreach (var s in ss)
                {
                    if (j == s)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
