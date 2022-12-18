using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_code
{
    internal class merge_sort
    {
        /*
         mergesort
        inputs->start,end,merge
        exit if end>=start 
        calculate middle point
        call mergesort(arr,middpoint)
        call mergesort(middpoint+1,arr)
         merge (arr,start,middpoint,end)
       */

        public void mergeSort(int[] arr, int start, int end)
        {
            if (end<= start) return ;

            int middpoint = (end + start) / 2;

            mergeSort(arr, start, middpoint);
            mergeSort(arr, middpoint + 1, end);

            merge(arr, start, middpoint, end);            
        }
        /*
        merge
         inputs-> arr,start,middpoint,end
       create 2 arrays
       merge the remaing
        */
        public void merge(int[] arr, int start, int middpoint, int end)
        {
            int left, right, k;
            left = right = 0;
            k = 0;
            int left_length = middpoint - start + 1;
            int right_length = end - middpoint;

            int[] left_array = new int[left_length];
            int[] right_array = new int[right_length];

            for (int i = 0; i < left_array.Length; i++)
            {
                left_array[i] = arr[start + i];

            }
            for (int i = 0; i < right_array.Length; i++)
            {
                right_array[i] = arr[middpoint+1+i];

            }
            k = start;
            while (left < left_length && right < right_length)
            {
                if (left_array[left] <= right_array[right])
                {
                    arr[k] = left_array[left];
                    left++;
                }
                else
                {
                    arr[k] = right_array[right];
                    right++;
                }
                k++;
            }

            //move the remaining

            while (left < left_length)
            {
                arr[k] = left_array[left];
                left++;
                k++;
            }

            while (right < right_length)
            {
                arr[k] = right_array[right];
                right++;
                k++;
            }
        }


    }
}
