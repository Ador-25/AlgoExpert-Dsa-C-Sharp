using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert_Easy
{
    public class Valid_Subsequence
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int slowPointer = 0;
            for(int fastPointer = 0; fastPointer < array.Count; fastPointer++)
            {
                if (array[fastPointer] == sequence[slowPointer])
                    slowPointer++;
                if (slowPointer == sequence.Count )
                    return true;
            }
            return false;
        }
    }
}
