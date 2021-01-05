using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Services.Lists
{
    public class ListService
    {
        public static List<int> MergeKSortedLists(List<List<int>> lists)
        {
            var k = lists.Count;
            var mergedList = new List<int>();
            for(int i = 0; i < k; i++)
            {
                mergedList = MergeLists(mergedList, lists[i]);
            }

            return mergedList;
        }

        public static List<int> MergeLists(List<int> left, List<int> right)
        {

            var mergedList = new List<int>();

            int leftIndex = 0;
            int rightIndex = 0;

            int leftLength = left.Count;
            int rightLength = right.Count;

            while(leftIndex < leftLength && rightIndex < rightLength)
            {
                if(left[leftIndex] <= right[rightIndex])
                {
                    mergedList.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    mergedList.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            while(leftIndex < leftLength)
            {
                mergedList.Add(left[leftIndex]);
                leftIndex++;
            }

            while(rightIndex < rightLength)
            {
                mergedList.Add(right[rightIndex]);
                rightIndex++;
            }

            return mergedList;
        }
    }
}
