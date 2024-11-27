using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Striver
{
    public class BinarySearch
    {
        public static void BinarySearchMain()
        {
            //int[] arr = new int[] { 1, 3, 5, 6, 7, 8, 12, 15, 19 };
            //int Index = RecursionBinarySearch(arr,0,arr.Length-1,1);
            //Console.WriteLine(" Index is " + Index);
            //LowerBoundBinarySearch();
            UpperBoundBinarySearch();
            //SearchInsertIndex();
        }

        public static int RecursionBinarySearch(int[] arr, int left, int right,int toFind)
        {
            if(left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == toFind) return mid;
                else if (arr[mid] < toFind) left = mid + 1;
                else if (arr[mid] > toFind) right = mid - 1;

                return RecursionBinarySearch(arr, left, right, toFind);
            }
            else
            {
                return -1;
            }
            // Overflow case with int max so use use  mid = left + (right -left) / 2 ;


        }
        // lower bound and upper bound comes into picture when there are repeated numbers
        // in this case simple BS will give index of any of the first number found
        // we need to find lower bound and upper bound in such case.
        public static void LowerBoundBinarySearch()
        {
            // smallest number in a array that greater or equall to the targert element
            int[] arr = new int[] { 1, 2, 3, 3, 4, 5, 6, 7, 7, 7, 9 };
            int left = 0; int right = arr.Length-1; int mid = 0; int find = 5;
            int ans = arr.Length;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (find <= arr[mid])
                {
                    ans = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1; 
                }
            }
            Console.WriteLine($" Lower Bound for {find} is " + ans);
        }
        public static void UpperBoundBinarySearch()
        {
            // smallest number in a array that is strictly grater than target element

            // below code is wrong
            int[] arr = new int[] { 1, 2, 3, 3, 4,5, 6, 7, 7, 7, 8, 9 };
            int left = 0; int right = arr.Length - 1; int mid = 0; int find = 7;
            int ans = arr.Length;
            while (left <= right)
            {

                mid = (left + right) / 2;
                if (find < arr[mid])
                {
                    ans = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            Console.WriteLine($" Upper Bound for {find} is " + ans);
        }
        public static void SearchInsertIndex()
        {
            int[] arr = new int[] { 1, 2, 5, 7 };
            int insert = 4;
            // find a index where 6 will be inserted
            // it is similar to finding a lower bound
            int left = 0; int right = arr.Length - 1; int mid = 0; 
            int ans = arr.Length;
            while (left <= right)
            {
                mid =(left + right) / 2;
                if (insert <= arr[mid])
                {
                    right = mid - 1;
                    ans = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            Console.WriteLine(ans);
        }
        public static void FloorCeil()
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            // if to find is 25 then floor is 20 ceil 30
            // lower bound is floor upper bound is ceil

        }
        public static void FirstLastOccurance()
        {
            int[] arr = new int[] { 2, 4, 6, 8, 8, 8, 11, 13 };
            // suppose if to find is 8 then we have to return [3,5] as ans
            // Brute force will be like do a lineat search and just keep track of 
            // first and last index found

            // but since it is sorted we will use Binary Search.
            // just find lower bound for first occurance and upperbound -1 for last occurance
            // also check if the number given by lower and upper bound algo check if it equall
            // to to find number
        }
    }
}
