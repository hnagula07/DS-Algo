﻿using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            {//Q1 RemoveDuplicates
           /* 
            int[] nums = new int[]{0,0,1,1,2,2,2,2,3,3,3};
            int newLength = RemoveDuplicates(nums);
            foreach(int i in nums){
                System.Console.Write(i);
            } */
            }
            
            {//Q2 Best Time to Buy and Sell Stock II
            // MaxProfit_StockMarket solution =  new MaxProfit_StockMarket();
            //   int[] prices = new int[]{7,1,5,3,6,4};//{7,6,4,3,1};//{1,2,3,4,5};//;

            //     int profit = solution.MaxProfit(prices);

            }
            {//Q3  Create Sorted Array through Instructions
            // Output: 26524
            // Expected: 26557
            //    Find_num_of_inversions_in_array solution =  new Find_num_of_inversions_in_array();
            //   int[] prices = new int[]{316,326,221,216,135,383,75,212,244,280,176,323,338,427,193,274,443,
            //   272,284,20,189,403,458,14,372,126,388,157,318,164,317,376,399,384,6,94,142,294,235,166,371,179,
            //   187,77,21,115,455,342,7,346,352,159,405,373,82,232,411,426,137,70,287,98,66,44,153,307,386,312,
            //   139,188,13,15,351,369,185,141,205,328,130,30,358,191,226,209,200,55,74,36,10,385,275,278,2,434,
            //   214,207,359,303,119,334,95,436,450,156,234,168,167,233,46,127,344,453,41,268,315,412,378,273,254,194,
            //   177,395,80,297,64,391,155,110,60,114,117,81,79,39,109,265,367,171,8,140,72,345,314,128,17,299,350,421,
            //   457,444,277,73,283,368,165,174,58,448,393,144,172,146,148,292,361,251,406,92,445,97,18,196,96,101,16,223,
            //   304,332,397,264,452,163,123,35,84,416,348,198,51,290,430,428,68,113,203,263,50,446,336,341,252,211,247,429,
            //   365,5,106,22,43,152,279,225,136,145,231,349,71,99,288,437,298,158,394,415,293,29,289,291,425,63,121,451,4,34,
            //   249,111,59,213,31,201,381,370,362,230,390,353,56,377,204,308,217,408,132,150,88,321,324,364,301,398,319,93,169,133,
            //   266,281,291,134,138,224,285,161,105,236,61,310,202,347,333,242,240,433,183,440,409,107,87,103,32,12,38,86,19,241,89,343,
            //   313,173,327,325,118,441,124,78,442,401,396,354,116,33,379,355,215,76,243,122,454,48,320,257,90,366,417,120,129,295,375,
            //   382,330,182,389,356,387,181,186,238,357,184,53,147,260,37,400,1,25,175,65,131,435,67,210,248,407,62,151,392,49,40,11,439,
            //   335,239,162,410,125,154,250,237,269,28,329,432,423,52,100,306,229,380,255,195,42,23,112,322,206,197,302,24,57,192,300,190,
            //   170,449,108,438,180,222,69,418,363,402,431,267,360,218,404,413,54,422,374,271,27,83,245,104,160,256,102,282,340,
            //   9,424,246,419,47,178,258,337,85,143,339,447,305,26,286,45,219,91,414,311,149,208,276,227,259,456,420,331,199,220,262,309,253,296,3,228,270,261};                 //{1,3,3,3,2,4,2,1,2};//{1,5,6,2};//{1,2,3,6,5,4};//;

            //     int cost = solution.CreateSortedArray(prices);
            //     System.Console.WriteLine("Cost to shift ={0}",cost);
            }
             {//Q4
        // Merge_Arrays m = new Merge_Arrays();
        // int[] Arr1 = new int[]{1,2,3,0,0,0};
        // m.Merge(Arr1, 3,new int[]{2,5,6}, 3);
        // printArray(Arr1);

        }
            {//Q5 RotateArray
            RotateArray R = new RotateArray();
             int[] Arr1 = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53};
             //{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21};
             //{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27};
             //{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54};
        R.Rotate(Arr1,82);
        printArray(Arr1);
            }
        }
        
        public static void printArray(int[] nums){
            int j=0;
            while(j< nums.Length)
            {
               System.Console.Write("{0}, ", nums[j]);
               j++;
            }
            System.Console.WriteLine("");
        }
    }
}
