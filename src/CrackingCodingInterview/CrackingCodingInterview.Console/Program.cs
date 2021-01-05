using System;
using System.Collections.Generic;
using CrackingCodingInterview.Service.Services.Matrices;
using CrackingCodingInterview.Services.Arrays;
using CrackingCodingInterview.Services.Lists;
using CrackingCodingInterview.Services.Strings;

namespace CrackingCodingInterview
{
    public class Program
    {
        static void Main(string[] args)
        {
            //in progress

            ListQuestions.MergeKSortedLists();


            //complete
            //MatricesQuestions.SprialMatrix();
            //StringQuestions.ValidParenthesis();
            //Arrays.TargetNum();
            //Arrays.FindWord();
            //StringQuestions.LongestPalindrom();
            //MatricesQuestions.FindIslands();
            //todo
            //Arrays.SmallestMissingInt();
        }
    }

    public static class StringQuestions
    {
        public static string r1 = "This is my string";
        public static string r2 = "";
        public static string r3 = ".. sdfjd 013  asd  thehe h.";
        /// <summary>
        /// Reverse the input string: COMPLETE
        /// </summary>
        public static void ReverseString()
        {
            Console.WriteLine("Reverse a given string.  But make sure to clear out the extra white space.");
            Console.WriteLine("original: {0}\nreverse: {1}", r1, r1.ReverseString());
        }
        /// <summary>
        /// Determine if the string is a valid parenthesis: COMPELTE
        /// </summary>
        public static void ValidParenthesis()
        {
            var test1 = "([{[{{{[{}]}}}]}){}{}()((}{))({})[[]]";
            var test2 = "{{[}}()[{}]";
            var test3 = "{{{}}})";

            Console.WriteLine(@"
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
");
            Console.WriteLine("test: {0}\n", string.Join(" ", test1));
            Console.WriteLine("answer: {0}\n", test1.ValidParenthesis());
            Console.WriteLine("test: {0}\n", string.Join(" ", test2));
            Console.WriteLine("answer: {0}\n", test2.ValidParenthesis());
            Console.WriteLine("test: {0}\n", string.Join(" ", test3));
            Console.WriteLine("answer: {0}\n", test3.ValidParenthesis());
        }

        public static void LongestPalindrom()
        {
            var test1 = "aaaaaaabaaacaaaa";
            var test2 = "abccba";
            var test3 = "abcaspda";

            Console.WriteLine(@"
Given a string s, return the longest palindromic substring in s.
");

            Console.WriteLine("test: {0}", test1);
            Console.WriteLine("answer: {0}\n", test1.LongestPalindrom());

            Console.WriteLine("test: {0}", test2);
            Console.WriteLine("answer: {0}\n", test2.LongestPalindrom());

            Console.WriteLine("test: {0}", test3);
            Console.WriteLine("answer: {0}\n", test3.LongestPalindrom());
        }

    }

    public static class Arrays
    {
        /// <summary>
        /// COMPLETE
        /// </summary>
        public static void TargetNum()
        {
            int target = 99;
            int[] array1 = new int[] { 0, 3, 6, 1, 5, 2, 7 };

            Console.WriteLine(@"
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.");

            var solution = ArrayService.FindTwoSum(array1, target);
            Console.WriteLine("target: {0}\narray: [{1}]", target, string.Join(", ",array1));
            Console.WriteLine("answer: [ {0}, {1} ]", solution?[0], solution?[1]);

        }

        /// <summary>
        /// TODO
        /// </summary>
        public static void FindWord()
        {
            var word = "CAEDC";
            char[][] board = new char[][]
            {
                new char[] { 'C', 'A', 'A', 'B', 'D' },
                new char[] { 'A', 'E', 'D', 'C', 'A' }
            };

            Console.WriteLine(@"
Given a 2D board and a word, find if the word exists in the grid.

The word can be constructed from letters of sequentially adjacent cells, where 'adjacent' cells are horizontally or vertically neighboring.
The same letter cell may not be used more than once.
");

            Console.WriteLine("Find Word: {0}\n", word);
            Console.WriteLine("Board:\n\n[{0}]\n[{1}]\n", string.Join(", ", board[0]), string.Join(", ", board[1]));
            Console.WriteLine("It Exists: {0}", ArrayService.FindWordInBoard(board, word));
        }

        /// <summary>
        /// TODO 
        /// </summary>
        public static void SmallestMissingInt()
        {
            int[] array1 = new int[] { 0, -1, 0, 2, 4, 5, 3, 5, 6, 7, 8, 8, 9, 1, 5, 6, -12, 4 };

            Console.WriteLine(@"
Given an unsorted integer array, find the smallest missing positive integer...
Your algorithm should run in O(n) time and uses constant extra space.");

            var solution = ArrayService.FindSmallestMissingNumber(array1);
            Console.WriteLine("array: [{0}]", string.Join(", ", array1));
            Console.WriteLine("answer: {0}", solution);
        }
    }

    public static class MatricesQuestions
    {
        /// <summary>
        /// COMPLETE
        /// </summary>
        public static void SprialMatrix()
        {
            Console.WriteLine(@"
Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
");

            var matrix = new int[][] {
                new int[]{1,2,3,4,5,6 },
                new int[]{4,5,6,7,5,6},
                new int[]{7,8,9,10,3,0},
                new int[]{7,8,9,10,3,0},
                new int[]{7,8,9,10,3,0}
            };


            Console.WriteLine(@" matrix:
[
    [{0}]
    [{1}]
    [{2}]
    [{3}]
    [{4}]
]
", string.Join(", ", matrix[0]), string.Join(", ", matrix[1]), string.Join(", ", matrix[2]), string.Join(", ", matrix[3]), string.Join(", ", matrix[4]));

            Console.WriteLine("answer: [{0}]", string.Join(", ", matrix.SpiralMatrix()));
        }


        public static void FindIslands()
        {
            Console.WriteLine("Given a M x N Matrix, find the number of islands.");

            var matrix = new int[][] {
                new int[]{1,1,1,0,0,0 },
                new int[]{1,1,0,0,0,0},
                new int[]{1,0,0,0,1,0},
                new int[]{0,0,0,1,1,0},
                new int[]{1,1,0,0,0,0}
            };


            Console.WriteLine(@" matrix map:
[
    [{0}]
    [{1}]
    [{2}]
    [{3}]
    [{4}]
]
", string.Join(", ", matrix[0]), string.Join(", ", matrix[1]), string.Join(", ", matrix[2]), string.Join(", ", matrix[3]), string.Join(", ", matrix[4]));


            Console.WriteLine("islands: {0}", matrix.FindIslands());
        }

    }

    public static class TreeQuestions
    {

    }

    public static class ListQuestions
    {
        public static void MergeKSortedLists()
        {
            Console.WriteLine(@"

You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.

Merge all the linked-lists into one sorted linked-list and return it.

");

            var lists = new List<List<int>>()
            {
                new List<int>() {1, 2, 4, 6, 8},
                new List<int>() {1, 2, 4},
                new List<int>() {3, 4, 5, 6, 6, 7},
                new List<int>() {0, 0, 0, 0, 1, 1, 1, 1, 1}
            };

            Console.WriteLine("[");
            foreach(var l in lists)
            {
                Console.WriteLine("\t{0}", string.Join("->", l));
            }
            Console.WriteLine("]");

            var mergedList = ListService.MergeKSortedLists(lists);

            Console.WriteLine("answer: {0}", string.Join("->", mergedList));
        }
    }
}
