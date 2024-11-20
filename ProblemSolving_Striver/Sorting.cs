using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Striver
{
    public class Sorting
    {
        public static void SortMain()
        {

        }

        public static void MergeSort(int[] arr,int l,int r)
        {
            if (l >= r) return;
            int mid = (l+r) / 2;
            MergeSort(arr,l,mid);
            MergeSort(arr,mid +1,r);
            foreach(int i in arr)
            {

            }
        }
    }
}
