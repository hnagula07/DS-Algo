using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    class RemoveDuplicates_Array
    {
        //https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
        // Runtime: 240 ms, faster than 88.16% of C# online submissions for Remove Duplicates from Sorted Array.
        // Memory Usage: 33.7 MB, less than 95.89% of C# online submissions for Remove Duplicates from Sorted Array.
        public static int RemoveDuplicates(int[] nums){
            if (nums.Length <=1)
             return nums.Length;
            int i = 0;
            int indexCheck = 0;
            while(i < nums.Length){
                if(i == 0)
                 nums[indexCheck] = nums[i];
                
                if(nums[indexCheck] != nums[i])
                    nums[++indexCheck] = nums[i];
                
                i++;

            }
            return ++indexCheck;
        }


    }
}