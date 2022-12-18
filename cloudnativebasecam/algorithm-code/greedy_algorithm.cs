using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_code
{
    internal class greedy_algorithm
    {
        /*
         one of method to solve optomization problem
        consists of many steps
        -sequential choices
        -local optimal solution(greedy choice)
        */
        public int[] activity_selection(int[] start_arr, int[] end_arr)
        {
            //2 arraies have the same length +sort by endTime
            List<int> result = new List<int>();
            result.Add(0);
            
            int end = 0;
            for (int start = 1; start < start_arr.Length; start++)
            {
                if (start_arr[start] >= end_arr[end])
                {
                    result.Add(start);
                    end = start;
                }

            }








            return result.ToArray();
        }
    }
}
