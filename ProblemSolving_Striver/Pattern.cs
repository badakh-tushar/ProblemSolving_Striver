using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Striver
{
    public class Pattern
    {
        public static void PatterMain()
        {
            // pattern1();
            //pattern2();
            pattern3();
        }

        public static void pattern1()
        {
            //    *
            //   ***
            //  *****
            // *******
            //*********
            int n = 10;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                for(int l = 0; l < i ; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void pattern2()
        {
            //*********   
            // *******
            //  *****
            //   ***
            //    *

            int n = 5;
            for ( int i=0; i<n; i++)
            {
                for(int j=0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=0; k < 2 * n - 2*i -1 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
        public static void pattern3()
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
            int n = 5;
            for(int i = 0; i <= 2*n-1; i++)
            {
                for(int j=0;j<i && i <=n; j++)
                {
                    Console.Write("*");
                }
                for(int j=0; j < 2*n-i && i>n ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
 