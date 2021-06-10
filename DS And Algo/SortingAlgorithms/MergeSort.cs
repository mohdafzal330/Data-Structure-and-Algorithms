using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_Algo.SortingAlgorithms
{
    public class MergeSort
    {
        public void Sort(int[] array)
        {
            //  [3,5,6,8,9,4,2,1]
            if (array.Length < 2) return;

            var mid = array.Length / 2;
            int[] left = new int[mid];
            for (int i = 0; i < mid; i++)
                left[i] = array[i];

            int[] right = new int[array.Length-mid];
            for (int i = mid; i < array.Length; i++)
                right[i-mid] = array[i];

            Sort(left);
            Sort(right);

            MergeArrays(left, right,array);
        }

        private void MergeArrays(int[] array1, int[] array2,int[] array)
        {
            int i = 0, j = 0, k = 0;
            while (i<array1.Length && j<array2.Length)
            {
                if (array1[i] <= array2[j])
                {
                    array[k++] = array1[i++];
                }
                else
                {
                    array[k++] = array2[j++];
                }
            }

            while (i < array1.Length)
                array[k++] = array1[i++];

            while (j < array2.Length)
                array[k++] = array2[j++];
        }
    }
}
