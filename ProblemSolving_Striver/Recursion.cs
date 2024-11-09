using System;
using System.Collections.Generic;
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
            SumNnumbers(3, 0);
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
    }
}
