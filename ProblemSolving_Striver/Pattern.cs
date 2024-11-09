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
            //pattern1();
            //pattern2();
            //pattern3();
            //pattern4();
            //pattern5();
            //pattern6();
            //pattern7();
            pattern8();
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
        public static void pattern4()
        {
            int n = 6;
            //1      1
            //12    21
            //123  321
            //12344321

            for(int i = 1; i <= n; i++)
            {
                for( int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for(int k = 0; k < 2 * n - 2*i; k++)
                {
                    Console.Write(" ");
                }
                for(int l = i; l > 0; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
        }

        public static void pattern5()
        {
            int n = 5;
            char ch = 'A';
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j<= i; j++)
                {
                    Console.Write(ch);
                    ch++;
                }
                Console.WriteLine();
                ch = 'A';
            }
        }
        public static void pattern6()
        {
            int n = 10;
            for(int i=0;i<n; i++)
            {
                for(int j=n-i;j>0; j--)
                {
                    Console.Write("*");
                }
                for(int k = 0; k < 2 * i; k++)
                {
                    Console.Write(" ");
                }
                for(int l = n - i; l > 0; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k < 2 * n - 2*i -2; k++)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l <=i ; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void pattern7()
        {
            //*        *
            //**      **
            //***    ***
            //****  ****
            //**********
            //****  ****
            //***    ***
            //**      **
            //*        *
            int n = 5;
            for (int i = 0; i <= 2 * n - 1; i++)
            {
                if (i == n) continue;
                for (int j = 0; j <= i && i < n; j++)
                {
                    Console.Write("*");
                }
                for( int j =0;j< 2*n -2*i -2  && i <=n; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0;j<=i && i<n; j++)
                {
                    Console.Write("*");
                }
                //for (int j = 0; j < 2 * n - i && i > n; j++)
                //{
                //    Console.Write("*");
                //}
                for(int j = 0;j<2*n -i && i>=n; j++)
                {
                    Console.Write("*");
                }
                for(int j = 0;j<2*i-2*n && i > n; j++)
                {
                    Console.Write(" ");
                }
                for(int j =0;j<2*n -i && i >= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public static void pattern8()
        {
            //****
            //*  *
            //*  *
            //****
            int n = 5;
            for( int i = 0; i < n; i++)
            {
                if(i < 1 ||  i >= n-1)
                {
                    for(int j = 0;j<n; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for(int j = 0; j < n - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write('*');
                }
                Console.WriteLine() ;
            }
        }


    }
}
 