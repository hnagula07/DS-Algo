using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    
// 29/65 cases were passed :(
    public class Find_num_of_inversions_in_array
    {
     public int CreateSortedArray(int[] instructions) {
        int[] nums = new int[instructions.Length];
        //1 5 6 2
        int cost = 0;
        int numsLength = 0;
        foreach(int inp in instructions){
            
            for(int i = 0; i<nums.Length;  i++){
                if(nums[i] == 0){
                nums[i] = inp;
                    numsLength++;
                    break;
                }
                if(nums[i] >= inp){
                    int ind = i;
                    int val =  inp;
                    int countRec = 0;
                    while(ind < numsLength+1){
                        
                      int oldVal = InsertHere(ind, nums, val);
                        
                        if(val != oldVal && oldVal != 0){  
                            countRec++;
                        }
                        
                          val = oldVal;
                        
                        ind++;
                    }
                    cost += Math.Min(i, countRec);
                    numsLength++;
                    break;
                }
            }
            
        }
        return cost;
    }       
     public int InsertHere(int i, int[] Arr, int inp){
            int oldVal= Arr[i];
                Arr[i] = inp;
           //System.Console.WriteLine("insideInsertHrere");

            return oldVal;
        }
        public void printArray(int[] nums){
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
