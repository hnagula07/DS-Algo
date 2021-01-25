using System;
public class RotateArray {
    public void Rotate(int[] nums, int k) {
        int oldValue = 0;
        int actual_K = k;
        if(k > nums.Length){
            actual_K = k%nums.Length;
        }
        int absLen = nums.Length - actual_K;
        int startIndex = absLen;

        int check = nums.Length;
        if(check%2 != 0)
            check -= 1;
//Console.WriteLine("AbsLen:{0}", absLen);
        if(nums.Length != startIndex){
            int i = 0;
            int count = 0;
            bool lastIndexWorks = false;
            while(startIndex < nums.Length+1 && i < check){
          //  Console.WriteLine("startIndex:{0}, i : {1}",startIndex,i);
                if(startIndex == nums.Length){
                    count++;
                    if( (actual_K/2) + actual_K == nums.Length)
                    break;
                    if(actual_K % absLen == 0 && nums.Length % absLen == 0)
                    break;
                    if(i > absLen){
                        if(count == 1 || lastIndexWorks){
                        startIndex = nums.Length-1;
                       // Console.WriteLine("actual_K:{0}, i : {1}",actual_K,i);
                        if(i> absLen){
                            startIndex = nums.Length - (i-absLen) ;
                        }
                        if(startIndex < i && (i-startIndex > actual_K)){
                            startIndex = nums.Length-1;
                        }
                        lastIndexWorks = true;
                       Console.WriteLine("Last index works startIndex:{0}, i : {1}, absLen:{2}, nums.Len:{3}",startIndex,i,absLen,nums.Length);
                        }
                        else
                        startIndex = nums.Length-absLen;
                    }
                    else{
                     startIndex = absLen;
                     count = 0;
                    }
                }
                
                //    Console.WriteLine(i); //2 = 3
                    // printArray(nums);
                oldValue =  nums[i];
                nums[i++] =  nums[startIndex];
                nums[startIndex++] = oldValue;
                   // Console.WriteLine(i); //2 = 3
             printArray(nums);
            }
        }
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