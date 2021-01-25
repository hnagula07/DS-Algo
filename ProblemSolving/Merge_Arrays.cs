using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    
// Runtime: 84 ms Your runtime beats 98.80 % of csharp submissions
// Memory Usage: 25.7 MB Your memory usage beats 83.67 % of csharp submissions
    public class Merge_Arrays
    {
       public void Merge(int[] nums1, int m, int[] nums2, int n) {
          
        if(n != 0){
            int remVal =0;
            int j = 0;
            for(int i = 0; i < n; i++ ){
                if(nums2[i] > remVal && remVal !=0){
                        remVal = nums1[j];
                       nums1[j] = remVal;
                        j = j+1;
                    }
                while(j< m-n){
                    if(nums2[i] >= nums1[j] ){
                       remVal = nums1[j];
                       nums1[j] = remVal;
                        j = j+1;
                    }else{
                        j++;
                    }
                 }
            }
            
        }
    }
    }
}
