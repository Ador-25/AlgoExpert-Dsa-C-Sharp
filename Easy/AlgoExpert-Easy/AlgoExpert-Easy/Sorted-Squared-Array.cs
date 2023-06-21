using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert_Easy
{
    public class Sorted_Squared_Array
    {
        public int[] SortedSquaredArray(int[] array)
        {
            int[] result = new int[array.Length];
            int splitPoint = -1;
            for(int i =0; i < array.Length; i++) 
            {
                if (array[i] >= 0) 
                { 
                    splitPoint = i;
                    break;
                }
            }
            if(splitPoint==-1)
            {
                int down= array.Length-1;
                for(int i=0;i<array.Length; i++)
                {
                    int get = array[down--];
                    result[i] = get*get;
                }
                return result;
            }

            int fastPointer = splitPoint;
            int slowPointer = splitPoint-1;
            int index = 0;
            while(slowPointer>=0 || fastPointer <array.Length)
            {
                if (slowPointer == -1)
                {
                    int num = GetMod(array[fastPointer++]);
                    result[index++] = num*num;
                    continue;
                }
                if(fastPointer == array.Length-1) 
                {
                    int num = GetMod(array[slowPointer--]);
                    result[index++] = num * num;
                    continue;
                }
                int first = GetMod(array[slowPointer]);
                int second = GetMod(array[fastPointer]);
                int low;
                
                if (first < second)
                {
                    low = first;
                    slowPointer--;

                }
                else
                {
                    low= second;
                    fastPointer++;
                }
                result[index++] = low * low;

            }
            return result;
        }

        private int GetMod(int n) => n<0? n*-1:n;
    }
}
