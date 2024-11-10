using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Striver
{
    public class Recursion
    {
        static int count = 0;
        public static void RecursionMain()
        {
            //recursion(count);
            //pattern(5, 0);
            //PrintOnetoN(10);
            //SumNnumbers(3, 0);
            //int sum=SumNnmubersMethod2(3);
            //Console.WriteLine(sum);
            //int fact = Factorial(5);
            //Console.WriteLine(fact);
            //    int[] ints = new int[] { 1, 2, 3, 4, 5 };
            //    reverseArray(0, ints, 5);
            //    foreach (int i in ints) { Console.WriteLine(i); }
            //Console.WriteLine(CheckPallindrom("madam", 0, 5));
            fibonacci(10, 0, 1);
        }
        public static void recursion(int count)
        {
            if (count == 3) return;
            Console.WriteLine("Tushar");
            count++;
            recursion(count);
            Console.WriteLine($"{count} Badakh");
        }

        public static void pattern(int n, int count)
        {
            //*
            //**
            //***
            //****
            //*****
            //****
            //***
            //**
            //*

            if (count == n) return;
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            count++;
            pattern(n, count);
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
        public static void PrintOnetoN(int n)
        {
            if (n == 0) return;
            PrintOnetoN(n - 1);
            Console.WriteLine(n);
        }
        public static void SumNnumbers(int n, int sum)
        {
            if (n == 0)
            {
                Console.WriteLine(sum);
                return;
            }
            sum = sum + n;
            SumNnumbers(n-1, sum);
        }

        public static int SumNnmubersMethod2(int n)
        {
            if (n == 0) return 0;
           return n + SumNnmubersMethod2(n - 1);
        }

        public static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
            // time complexity is O(N)
        }

        public static void reverseArray(int i , int[] arr , int n )
        {
            if (i > n / 2) return;
            int temp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = temp;
            i++;
            reverseArray(i , arr , n );

        }

        public static bool  CheckPallindrom(string str,int i,int n)
        {
            if (i > n / 2) 
                return true; 
            if (str[i] != str[n - i - 1]) 
                return false;
            return CheckPallindrom(str, i + 1, n);

        }

        public static void fibonacci(int count,int sum1 , int sum2)
        {
            // 0,1,1,2,3,5,8,13,21,34,55....
            if(count == 0) return;
            count--;
            Console.Write(" " + sum2);
            int tmp = sum2;
            sum2 = sum1 + sum2;
            sum1 = tmp;
            fibonacci(count, sum1, sum2);
        }
    }
}
