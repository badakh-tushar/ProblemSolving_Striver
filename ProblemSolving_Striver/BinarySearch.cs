using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
            //UpperBoundBinarySearch();
            //SearchInsertIndex();
            //FindPivotRotatedArray();
            //SearchInRotatedSortedArray();
            MinimumElementSortedArray();
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

        public static void FindPivotRotatedArray() // or find Peak Element
        {
            int[] arr = new int[] {  1,2,3,4,5,6 };

            //int left=0,right=arr.Length - 1;
            //while (left <= right)
            //{
            //    int mid= (left + right) / 2;
            //    if (arr[mid] > arr[mid-1] && arr[mid] > arr[mid +1])
            //    {
            //        Console.WriteLine(mid);
            //        break;
            //    }
            //    else if (arr[mid] < arr[left] && arr[mid] < arr[right])
            //    {
            //        right = mid - 1;
            //    }
            //    else
            //    {
            //        left = left + 1;
            //    }
            //}
            //int[] arr = new int[] { 6, 7, 8, 9, 1, 2, 3, 4, 5 };

            // this is excellant question do it twice.
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if mid is the pivot
                if (mid < right && arr[mid] > arr[mid + 1])
                {
                    Console.WriteLine($"Pivot index: {mid}");
                    return;
                }
                if (mid > left && arr[mid] < arr[mid - 1])
                {
                    Console.WriteLine($"Pivot index: {mid - 1}");
                    return;
                }

                // Decide the side to search
                if (arr[mid] >= arr[left])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine("Pivot not found");
        }
        public static void SearchInRotatedSortedArray()
        {
            int[] arr = new int[] { 4, 5, 6, 7, 0, 1, 2 };
            int k = 1;
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == k)
                {
                    Console.WriteLine($"Elemenet found at {mid} ");
                    break;
                }
                if (arr[left] == k)
                {
                    Console.WriteLine($"Elemenet found at {left} ");
                    break;
                }
                if (arr[right] == k)
                {
                    Console.WriteLine($"Elemenet found at {right} ");
                    break;
                }
                if (arr[left] < arr[mid])
                {
                    // comare k with right most elem
                    if (arr[left] < k && k < arr[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (k < arr[right] && arr[mid]<k)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }

            }

           
        }
        public static void SearchInRotatedSortedArrayWithDuplicates()
        {
            // [3,1,2,3,3,3,3]
            //in this case we might not b ablet to find the sorted half
            // so what we will do is once we get array of left mid and right element as same
            // then we trim the array and keep on doing it until we get to know sorted half
            // like do left++ right-- and see of sorted half condition satifies
            // one more thing we just have to return the if the target element exixt or not
            // not the index of target element
        }
        public static void MinimumElementSortedArray()
        {
            //int[] arr = new int[] { 4, 5,6, 1, 2,3};
            //int[] arr = [2,1];
            int[] arr = [1,2];
            int left = 0, right = arr.Length - 1, mid = 0; ;
            while (left <= right)
            {
                 mid = (left + right) / 2;
               
                if (mid != 0 && arr[mid] < arr[mid - 1]   )
                {
                    Console.WriteLine(mid);
                    break;
                }

                if (arr[mid] >= arr[left] && arr[mid] >= arr[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            Console.WriteLine( arr[mid]);
        }
    }
}
