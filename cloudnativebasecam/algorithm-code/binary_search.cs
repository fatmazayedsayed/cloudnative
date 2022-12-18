using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_code
{
    internal class binary_search
    {
        public int binarysearch(int[] arr, int searchItem)
        {
            /*get the mid
             check mid with the searchItem
            mid>searchItem ->search on left
            else seach on right

             */
            int index = -1;
            int low = 0;
            int high = arr.Length - 1;
            int middle = 0;
            while (low <= high)
            {
                middle = (low + high) / 2;

                if (searchItem == arr[middle])
                {
                    return middle;
                }
                else
                {
                    //move 
                    if (searchItem > arr[middle])
                    {
                        //move low
                        low = middle + 1;
                    }

                    else
                    {
                        //move high
                        high = middle - 1;
                    }
                }
            }
            return index;
        }


    }
}
