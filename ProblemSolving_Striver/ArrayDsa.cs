﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Striver
{
    public class ArrayDsa
    {
        public static void ArrayDsaMain()
        {
            //SecondLargestElementArray();
            //LeftRotateArrayOnePlace();
            //LeftRotateArrayDPlaces();
            //MoveAllZerosToEndArray();
            //UnionOfSortedArray();
            // MissingNumber();
            //MaxmConsequetiveOnes();
            //LongestSubarrayWithSumK();
            // LongestSubArraySumApproach2();
            //SortZerOneTwo();
            //MajorityElement();
            MaximumSubArraySum();
        }
        public static void SecondLargestElementArray()
        {
            int[] arr = new int[] { 1, 5, 2, 9, 9, 9, 3, 7 };

            // sort and then comapre if the secod last is not same as last if not mark it as secod largest
            int secondLarge = arr[0];
            int largest = arr[0];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] > largest)
                {
                    if (largest != secondLarge)
                        secondLarge = largest;
                    largest = arr[i];

                }
                else if (arr[i] > secondLarge && arr[i] != largest)
                    secondLarge = arr[i];
            }
            if (largest == secondLarge)
                Console.WriteLine("No second largest element");
            else
                Console.WriteLine("Second Largest " + secondLarge);

        }
        public static void LeftRotateArrayOnePlace()
        {
            int[] arr = new int[] { 1, 4, 6, 7, 8 };
            // do not use new array
            // {4,6,7,8,1}
            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = temp;

            foreach (int i in arr) Console.WriteLine(i);
        }
        public static void LeftRotateArrayDPlaces()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int d = 3;
            d = d % arr.Length;
            // 4,5,6,7,1,2,3
            // if d is large than array size then do d= d%n
            // brute forccce will be storing the elements to be shifted in  some other array
            Reverse(arr, 0, d - 1);
            Reverse(arr, d, arr.Length - 1);
            Reverse(arr, 0, arr.Length - 1);
            foreach (int ele in arr) Console.Write(ele);
        }
        public static int[] Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            return arr;
        }
        public static void MoveAllZerosToEndArray()
        {
            int[] arr = new int[] { 0, 1, 3, 0, 0, 4, 0, 5, 6, 0, 0, 0, 7, 0, 0 };
            // o/p {1,3,4,5,6,7,0,0,0,0}
            int j = 0;
            bool zeroFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0 && !zeroFound)
                {
                    j = i;
                    zeroFound = true;
                }
                if (zeroFound && arr[i] != 0)
                {
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    j++;
                }
            }

            foreach (int ele in arr) Console.Write(ele);
        }
        public static void UnionOfSortedArray()
        {
            int[] arr = new int[] { 1, 2, 2, 4 };
            int[] arr2 = new int[] { 1, 2, 3 };
            // op {1,2,4,5,6,7,8,9}
            // brute force use hashSet

            int i = 0; int j = 0;
            int max = Math.Max(arr.Length, arr2.Length);
            int min = Math.Min(arr.Length, arr2.Length);
            HashSet<int> set = new HashSet<int>();

            while (i < min && j < min)
            {
                if (arr[i] == arr2[j])
                {
                    set.Add(arr[i]);
                    i++; j++;
                }
                else if (arr[i] < arr2[j])
                {
                    set.Add(arr[i]);
                    i++;
                }
                else
                {
                    set.Add(arr2[j]);
                    j++;
                }
            }
            if (i < arr.Length)
            {
                for (int m = j; m < arr2.Length; m++)
                {
                    set.Add(arr2[m]);

                }
            }
            if (j < arr2.Length)
            {
                for (int n = i; n < arr.Length; n++)
                {
                    set.Add(arr[n]);

                }
            }

            foreach (int ele in set) Console.Write(ele + ",");

        }

        // find intersection in sorted array is pending

        public static void MissingNumber()
        {
            // numbers will be from 1 to N 
            // https://leetcode.com/problems/missing-number/
            int[] nums = new int[] { 3, 0, 1 };
            HashSet<int> setNums = new HashSet<int>();
            foreach (int ele in nums)
            {
                setNums.Add(ele);
            }
            int i = 0;
            while (i <= nums.Length)
            {
                if (setNums.Contains(i))
                    i++;
                else
                { Console.WriteLine(i); break; }
            }
        }
        public static void MissingNumberSolution2()
        {
            // numbers will be from 1 to N 
            // https://leetcode.com/problems/missing-number/
            int[] nums = new int[] { 3, 0, 1 };
            int n = nums.Length;
            int sum = (n * (n + 1)) / 2;
            int currentSum = 0;
            foreach (int ele in nums)
            {
                currentSum += ele;
            }
            int missingele = sum - currentSum;
            Console.WriteLine(missingele);
        }

        public static void MaxmConsequetiveOnes()
        {
            int[] arr = new int[] { 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 0 };
            int count = 0, maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    count++;
                }
                else
                {
                    if (count > maxCount) maxCount = count;
                    count = 0;
                }
            }
            if (count > maxCount) Console.WriteLine("Max Count ofone's" + count);
            Console.WriteLine("Max Count ofone's" + maxCount);
        }

        public static void NumberOnesOtherTwice()
        {
            // 1,1,2,3,3,4,4

            // use two for loops
            // use hash and see frequency and which has frequency one will be one
            // use XOR
        }

        public static void LongestSubarrayWithSumK()
        {
            int[] arr = new int[] { 1, 0, 0, 8, 0, 0, 0, 1, 1, 1, 4, 2, 3 };
            // sum of contigues part of array with a given sum
            // brute force will be use two for loops

            // secod aproach is find cummulative sum at each location like for
            // abov array sum array will be { 1,3,6,7,8,9,10,14,16,19 }
            // now will store them in a hashmap with key as sum and index as value

            int k = 9;
            int sum = 0;
            int start = 0, end = 0;
            int length = 0, lengthMax = 0; ;
            Dictionary<int, int> cummulativeSum = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (!cummulativeSum.ContainsKey(sum))
                    cummulativeSum.Add(sum, i);
            }
            if (cummulativeSum.ContainsKey(k)) lengthMax = cummulativeSum[k] + 1;

            foreach (KeyValuePair<int, int> pair in cummulativeSum)
            {
                int find = k + pair.Key;
                if (cummulativeSum.ContainsKey(find))
                {
                    length = cummulativeSum[find] - pair.Value;
                    if (length > lengthMax) lengthMax = length;
                }
                find = 0;
            }

            Console.WriteLine("Length " + lengthMax);

            // above code  will work fine for only positive numbers
            //int[] arr = new int[] { 1, 0, 0, 8, 0, 0, 0, 1, 1, 1, 4, 2, 3 };
            //int k = 9;

            //int sum = 0;
            //int lengthMax = 0;
            //Dictionary<int, int> cummulativeSum = new Dictionary<int, int>();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];

            //    // If the cumulative sum equals k, update lengthMax
            //    if (sum == k)
            //    {
            //        lengthMax = i + 1; // From the start to the current index
            //    }

            //    // Check if (sum - k) exists in the dictionary
            //    if (cummulativeSum.ContainsKey(sum - k))
            //    {
            //        int length = i - cummulativeSum[sum - k];
            //        if (length > lengthMax)
            //        {
            //            lengthMax = length;
            //        }
            //    }

            //    // Only add the first occurrence of a cumulative sum to the dictionary
            //    if (!cummulativeSum.ContainsKey(sum))
            //    {
            //        cummulativeSum[sum] = i;
            //    }
            //}

            //Console.WriteLine("Maximum Length: " + lengthMax);



        }

        public static void LongestSubArraySumApproach2()
        {
            int[] arr = new int[] { 1, 0, 0, 8, 0, 6, 1, 1, 1, 1, 4, 2, 3 };
            int left = 0, right = 1;
            int sum = 0; int length = 0; int lengthMax = 0; int k = 9;
            sum = sum + arr[left];
            while (left <= right && right < arr.Length - 1)
            {
                if (sum == k)
                {
                    length = right - left;
                    if (length > lengthMax) lengthMax = length;
                    right++;
                }
                if (sum < k)
                {

                    sum += arr[right];
                    right++;
                }
                else
                {

                    sum -= arr[left];
                    left++;
                }
            }
            Console.WriteLine("Maxm Length is " + lengthMax);

        }
        public static void TwoSumProblem()
        {
            int[] arr = new int[] { 2, 6, 5, 8, 11 };
            int sum = 14;
            // use hashing store numbers after checking diffrence is there or not
            // second approach is to sort and use two pointers
            for (int i = 0; i < arr.Length; i++)
            {

            }
        }
        public static void SortZeroOne()
        {
            int[] arr = new int[] { 0, 1, 1, 0, 0, 0, 1, 1, 1, 0 };
            // just swap bro skip if its zero at first and swap with one
            // use to pointers from left and right

        }
        public static void SortZerOneTwo()
        {
            int[] arr = new int[] { 0, 1, 1, 2, 2, 2, 0, 0, 0, 1, 2, 2, 1, 0, 1 };
            int z = 0, o = 0, t = 0;
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                if (arr[left] == 1 && arr[right] == 0 || arr[left] == 2 && arr[right] == 0)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                    continue;
                }
                else if (arr[left] == 0)
                {
                    left++;
                }
                right--;
            }
            right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] == 2 && arr[right] == 1)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                    continue;
                }
                else if (arr[left] == 1)
                {
                    left++;
                }
                right--;
            }

            foreach (int i in arr) Console.Write(i + ",");

            // check other solutions on GFG
            // one solution involves counting 0 1 2 and then population them in array
            // Ducth national flag algo tries sorting just like above but in one go 
            // by only tracking low mid and high and sorting low mid in if arr[mid] ==0
            // else if arr[mid] ==1 then mid ++
            // and in lese that is if arr[mid] is 2 then swap with mid and high
        }

        public static void MajorityElement()
        {
            // find a element which appears greater than N/2 times in an array
            // note it is more than N/2 not equall

            int[] arr = new int[] { 2, 2, 3, 3, 1, 2, 2 };
            // use hashing for better solution

            // optimal solution Moore's Voting Algo

            // we need to understand the thought process and intution behind the algo
            int count = 0; int ele = arr[0];
            for( int i=0;i<arr.Length; i++ )
            {
                if (count == 0)
                {
                    ele = arr[i];
                    count = 1;
                }
                else if (ele == arr[i]) count++;
                else count--;
            }
            int count1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (ele == arr[i]) count1++;
            }
            if (count1 > arr.Length / 2)
            {
                Console.WriteLine("Am majority " + ele);

            }
            else
            {
                Console.WriteLine("No one in majority");
            }
        }

        public static void MaximumSubArraySum()
        {
            int[] arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            // -2,1,-2,2,1,3,4,-1,3
            // here this is my solution here i have done a cummulative summations of 
            // all the elements and whichver is the longest sequence of positive numbers gives me 
            // longest sequence of the maximum sub array go and sum it

            // optimal solution is kadane's algo

            // here the simple idea is to make the sum zero whenever it becomes neagative 
            int sum = 0 ; int sumMax = 0; bool flag = true;
            for (int i = 0;i<arr.Length;i++)
            {
                sum += arr[i];
                if (sum > sumMax) sumMax = sum;
                if(sum <0) sum = 0;
            }
            Console.WriteLine(sumMax);
        }
    }

    
    }
