public class Solution {
    public int Search(int[] nums, int target) 
    {
        var start = 0;
        var end = nums.Length - 1;
      
        while(start <= end)
        {
            var midle = start + (end - start) / 2;
            
            if(nums[midle] == target)
                return midle;
            
            if(nums[midle] > target)
            {
                end = midle - 1;
                continue;
            }
            
            if(nums[midle] < target)
            {
                start = midle + 1;
                continue;
            }
        }
        
        return -1;
    }
}