using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Striver
{
    public class StringDSA
    {
        public static void StringMain()
        {
            //RemoveOutermostParenthesis();
            //Console.WriteLine(ReverseWords("the sky is blue"));
            //LargestOddString();
            LongestCommonPrefix();
        }
        public static void RemoveOutermostParenthesis()
        {
            //Input: s = "(()())(())"
            //Output: "()()()"
            //Input: s = "(()())(())(()(()))"
            //Output: "()()()()(())"
            string str = "(()())(())";
            string str2 = "";
            for (int i = 0; i < str.Length; i++) 
            {
                if (str[i] == '(' && str[i + 1] == '(')
                {
                     str2=str.Remove(i);
                }
            }
            Console.WriteLine(str2);
        }
        public static string ReverseWords(string s)
        {
            //string[] str = [];
            //foreach (char c in s)
            //{
            //    if (c != ' ')
            //    {

            //    }
            //}
            //StringBuilder reverse = new StringBuilder();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    reverse.Append(str[i]);
            //    reverse.Append(' ');
            //}
           
            //return reverse.ToString().Trim();

            var words = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words.Reverse());
        }
        public static void LargestOddString()
        {
            //string s = "5234"; // ans is "523"
            //long num = Convert.ToInt64(s);
            //while (num > 0)
            //{
            //    if (num % 2 == 0)
            //    {
            //        num = num / 10;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Largest odd " + num.ToString());
            //        break;
            //    }
            //}
            // this code will not work for large number strings so we havt o solve it as a string

            string s = "14973602812922";
            for (int i = s.Length-1; i >=0; i--)
            {
                int num = s[i];
                if(num % 2 != 0)
                {
                    string ans = s.Substring(0, i+1);
                    Console.WriteLine(ans);
                    break;
                }
            }

        }
        public static void LongestCommonPrefix()
        {
            string[] s = ["flower", "flow", "flight"];
            //string[] s = [""];
            //string[] s = ["","b"];
            //string[] s = ["ab", "a"];
            var ans = new StringBuilder();
            int i = 0;
            int minLength = 10000;
            for(int m = 0; m < s.Length; m++)
            {
                minLength = Math.Min(minLength, s[m].Length);
            }
            if (s.Length > 0 && !s[i].Equals(String.Empty))
            {
                for (i = 0; i < minLength; i++)
                {
                    int j = 0;
                    bool flag = true;// keep it true if only one string in array
                    
                    while (j < s.Length - 1)
                        {
                            if ( s[j][i] == s[j + 1][i])
                            {
                                flag = true;
                            }
                            else
                            {
                                flag = false;
                            break;
                            }
                            j++;
                        }
                        if (flag)
                            ans.Append(s[j][i]);
                        else
                            break;
                    
                    
                }
            }
            
            Console.WriteLine(ans.ToString());
        }
    }
}
