public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int start = 0;
        int end = nums.Length -1;
        int mid = start + (end-start)/2;
        
        while ( start <= end )
        {
            mid = start + (end-start)/2;
            
            if( nums[mid] == target )
            {
                    return mid;
            }
            else if( target > nums[mid] )
            {
                start = mid + 1;
            }
            
            else if( target < nums[mid] )
            {
                end = mid - 1;
            }

        }
      
        return start;
        
    }
}