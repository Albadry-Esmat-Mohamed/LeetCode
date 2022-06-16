public class Solution {
    public int Search(int[] nums, int target) {
        
        int low   = 0;
        int high  = nums.Length -1;
        int mid   = 0;
        
        while ( low <= high )
        {
            mid = (low + high)/2 ;
         
            if(nums[mid] == target)
            return mid;
            
            if(target > nums[mid])
            {  low = mid + 1;
                continue;
            }
            if(target < nums[mid])
            {
                high = mid - 1;  
                continue;
            }
        }
            return -1;
    }
}