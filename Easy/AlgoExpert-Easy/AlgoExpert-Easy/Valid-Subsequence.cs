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
            for(int i = 0; i < array.Count; i++)
            {
                if(array[i] == sequence[slowPointer])
                {
                    slowPointer++;
                    
                }
            }
            return slowPointer==sequence.Count-1;
        }
    }
}
