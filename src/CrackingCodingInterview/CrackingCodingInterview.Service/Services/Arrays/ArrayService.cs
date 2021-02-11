using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Services.Arrays
{
    public class ArrayService
    {

        #region Find Two Numbers That Sum to a target
        public const int PAIRSIZE = 2;
        public static int[] FindTwoSum(int[] array, int target)
        {

            var integerDictionary = new Dictionary<int, int>();
            var targetIndexPair = new int[PAIRSIZE];

            for(int i = 0; i < array.Length; i++)
            {
                var currentValue = array[i];
                var complement = target - currentValue;
                if (!integerDictionary.ContainsKey(complement))
                {
                    integerDictionary.Add(currentValue, i);
                }
                else
                {
                    targetIndexPair[0] = i;
                    targetIndexPair[1] = integerDictionary.GetValueOrDefault(complement);
                    return targetIndexPair;
                }
            }

            return null;
            
            
        }

        #endregion


        #region Find a Word in a 2D board
        public static bool FindWordInBoard(char[][] board, string word)
        {
            var columns = board[0].Length;
            var rows = board.Length;

            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++)
                {
                    if(DFS(i, j, word, 0, board))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool DFS(int rows, int columns, string word, int index, char[][] board )
        {
            var boardCol = board[0].Length - 1;
            var boardRow = board.Length - 1;
            //we found the word
            if (index >= word.Length)
                return true;

            //check boundarys
            if (rows < 0 || rows == boardRow || columns < 0 || columns == boardCol || board[rows][columns] != word[index])
                return false;

            var response = false;
            board[rows][columns] = '#';

            var rowOffset = new int[4] { 0, 1, 0, -1 };
            var colOffet = new int[4] { 1, 0, -1, 0 };
            for(int i = 0; i < 4; i++)
            {
                response = DFS(rows + rowOffset[i], columns + colOffet[i], word, index++, board);
                if(response)
                {
                    
                    break;
                }
            }

            board[rows][columns] = word[index];
            return response;
        }
        #endregion



        #region Can Jump
        public static int CanReach(int[] A, int N)
        {

            if(N == 1)
            {
                return 1;
            }

            return CanReachDFS(A, 0, A[0], N);
        }

        private static int CanReachDFS(int[] A, int index, int jump, int size)
        {
            if(index >= size - 1)
            {
                return 1;
            }

            for(int i = jump; i >= 0; i--)
            {
                CanReachDFS(A, index + i, A[index + i], size);
            }

            return 0;
        }
        #endregion




        public static int FindSmallestMissingNumber(int[] numArray)
        {

            var integerDictionary = new Dictionary<int, int>();
            int size = numArray.Length;
            //cleanup array and make sure every number is a positive non-zero number.  We don't care about 0 and negatives
            for(int i = 0; i < numArray.Length; i++)
            {
                if(numArray[i] < 1)
                {
                    numArray[i] = 1;
                }
            }

            for(int i = 0; i < numArray.Length; i++)
            {
                if(integerDictionary.ContainsKey(numArray[i]))
                {
                    integerDictionary[numArray[i]] += 1;
                }
                else
                {
                    integerDictionary.Add(numArray[i], 1);
                }
            }

            for(int i = 1; i < size; i++)
            {
                if(!integerDictionary.ContainsKey(i))
                {
                    return i;
                }
            }

            return 0;
        }

    }
}
