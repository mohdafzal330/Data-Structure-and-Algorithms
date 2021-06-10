
namespace DS_And_Algo
{
    using DS_And_Algo.SortingAlgorithms;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 4,6,10,9,2,6,8,4,9,3};
            MergeSort mergeSort = new MergeSort();
            mergeSort.Sort(A);
            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i] + " ");
            Console.ReadKey();
        }
        
    }
}
