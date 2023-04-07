using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert_Easy
{
    public class Two_Number_Sum
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int required = targetSum - array[i];
                if (set.Contains(required))
                {
                    return new int[2] { required, array[i] };
                }
                set.Add(array[i]);
            }
            return new int[0];
        }
    }
}
