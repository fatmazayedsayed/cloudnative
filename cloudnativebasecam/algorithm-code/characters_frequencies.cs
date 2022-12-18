using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_code
{
    internal class characters_frequencies
    {
        public void ASCIIMethod(string message)
        {
            Console.WriteLine("ASCIIMethod");

            int[] freq = new int[127];
            int current_code = 0;
            for (int i = 0; i < message.Length; i++)
            {
                current_code = (int)message[i];
                freq[current_code]++;
            }
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine($"character {(char)i} is repeated {freq[i]} times");
                }
            }

        }


        public void UTFMethod(string message)
        {
            /*using hash table has key/value
             
             no need to define the length
             */
            Console.WriteLine("UTFMethod");
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < message.Length; i++)
            {
                if (hashtable[message[i]]==null)
                {
                    hashtable[message[i]] = 1;
                }
                else
                {
                    hashtable[message[i]] = (int)hashtable[message[i]] + 1;
                }
            }
            foreach (char key in hashtable.Keys)
            {
                Console.WriteLine($"the character {key} is repeated {hashtable[key]}");
            }
            sortHash(hashtable);
            //sort using merge sort nlog n
            Console.WriteLine("After Sorting....");
            foreach (char key in hashtable.Keys)
            {
                Console.WriteLine($"the character {key} is repeated {hashtable[key]}");
            }
        }
        void sortHash(Hashtable hashtable)
        {
            int[,] freq = new int[hashtable.Count, 2];
            int i = 0;
            foreach (char key in hashtable.Keys)
            {
                freq[i, 0] = (int)key;
                freq[i, 1] = (int)hashtable[key];
            }

            mergeSort(freq, 0, hashtable.Count - 1);
        }
        void mergeSort(int[,] arr, int start, int end)
        {

            if (end <= start) return;
            int mid = (end + start) / 2;
            mergeSort(arr, start, mid);
            mergeSort(arr, mid + 1, end);

            merge(arr, start, mid, end);
        }
        public void merge(int[,] arr, int start, int middpoint, int end)
        {
            int i, j, k;
           
            int left_length = middpoint - start + 1;
            int right_length = end - middpoint;

            int[,] left_array = new int[left_length,2];
            int[,] right_array = new int[right_length,2];

            for ( i = 0; i < left_length; i++)
            {
                left_array[i,0] = arr[start + i,0];
                left_array[i,1] = arr[start + i,1];

            }
            for ( j = 0; j < right_length; j++)
            {
                right_array[j,0] = arr[middpoint + 1 + j,0];
                right_array[j,1] = arr[middpoint + 1 + j,1];

            }
            i = j = 0;
             k = start;
            while (i < left_length && j < right_length)
            {
                if (left_array[i,0] <= right_array[j,0])
                {
                    arr[k,0] = left_array[i,0];
                    arr[k,1] = left_array[i,1];
                    i++;
                }
                else
                {
                    arr[k,0] = right_array[j,0];
                    arr[k,1] = right_array[j,1];
                    j++;
                }
                k++;
            }

            //move the remaining

            while (i < left_length)
            {
                arr[k,0] = left_array[i,0];
                arr[k,1] = left_array[i,1];
                i++;
                k++;
            }

            while (j < right_length)
            {
                arr[k,0 ]= right_array[j,0];
                arr[k,1 ]= right_array[j,1];
                j++;
                k++;
            }
        }
    }
}
