using System;
using System.Text;
using System.Linq;
using System.Collections;

namespace CrackingCodingInterview.Services.Strings
{
    public static class StringService
    {
        /// <summary>
        /// COMPLETE
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(this string s)
        {
            var splitString = s.Split(" ");

            if(splitString.Length == 0)
            {
                return s;
            }
            else if(splitString.Length == 1)
            {
                return s;
            }
            else
            {

                splitString = splitString.Where(s => !string.IsNullOrEmpty(s)).ToArray();
                splitString = splitString.Reverse().ToArray();
                return String.Join(" ", splitString);
            }

        }
        /// <summary>
        /// COMPLETE
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool ValidParenthesis(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            if (s.Length % 2 == 1)
            {
                return false;
            }

            var parenthesisStack = new Stack();

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '{' || s[i] == '[' || s[i] == '(')
                {
                    parenthesisStack.Push(s[i]);
                }
                else if(s[i] == '}')
                {
                    if((char)parenthesisStack.Peek() == '{')
                    {
                        parenthesisStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (s[i] == ')')
                {
                    if ((char)parenthesisStack.Peek() == '(')
                    {
                        parenthesisStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (s[i] == ']')
                {
                    if ((char)parenthesisStack.Peek() == '[')
                    {
                        parenthesisStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

            }


            return true;
        }



        static int count = 1;
        static string palindrome = "";
        /// <summary>
        /// IN PROGRESS
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string LongestPalindrom(this string s)
        {
            count = 1;
            int left = 0;
            int right = s.Length - 1;


            return palindrome;
        }

        //private static bool FindPalindrome(string s, int left, int right)
        //{
        //    if (s.Length == 1)
        //    {
        //        return true;
        //    }
        //    else if(s.Length == 2)
        //    {
        //        if (s[0] == s[1])
        //        {
        //            return true;
        //        }
        //    }
        //    else if(s.Length == 3)
        //    {
        //        if (s[0] == s[2])
        //        {
        //            return true;
        //        }
        //    }

        //    var left = 0;
        //    var right = s.Length;
        //    while (left < right)
        //    {
        //        if (s[left] != s[right])
        //        {
        //            return false;
        //        }
        //        left++;
        //        right--;
        //    }

        //    return true;

        //}


    }
}
