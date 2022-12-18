using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_code
{
    internal class segregate
    {

        public void segregateNumber(int[] arr, int start, int end)
        {
            /*
             start check the left array
            move negative numbers only
            both subarrays could have remainig items
            all remainig numbers should be positive only
            start moving remaining from left subarray then right subarray
             */
            if (end <= start) return;

            int middpoint = (start + end) / 2;
            segregateNumber(arr, start, middpoint);
            segregateNumber(arr, middpoint + 1, end);

            mergeSort(arr, start, middpoint, end);

        }

        void mergeSort(int[] arr, int start, int middpoint, int end)
        {
            int left, right, k;
            left = right = 0;
            k = 0;
            int left_length = middpoint - start + 1;
            int right_length = end - middpoint;

            int[] left_array = new int[left_length];
            int[] right_array = new int[right_length];
            ////////////////fill array
            for (int i = 0; i < left_array.Length; i++)
            {
                left_array[i] = arr[start + i];
            }
            for (int i = 0; i < right_array.Length; i++)
            {
                right_array[i] = arr[middpoint + 1 + i];
            }


            k = start;
            /////////////////compare
            while (left < left_length && left_array[left] <= 0)
            {
                arr[k] = left_array[left];
                left++;
                k++;
            }
            while (right < right_length && right_array[right] <= 0)
            {
                arr[k] = right_array[right];
                right++;
                k++;
            }
            ///////////////////remainig////////////////////
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



        public int[] segregateNumber2(int[] arr)
        {
            /*
           add number to corrsponding array accorrding to its sign
            merge the two arrays
             */
            List<int> negative_array = new List<int>();
            List<int> positive_array = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                { positive_array.Add(arr[i]); }
                else
                { negative_array.Add(arr[i]); }
            }
            //
            foreach (var item in positive_array)
            {
                negative_array.Add(item);
            }
            return negative_array.ToArray();
        }


    }
}
