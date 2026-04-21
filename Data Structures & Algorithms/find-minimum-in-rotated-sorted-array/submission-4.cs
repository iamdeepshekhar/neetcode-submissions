public class Solution {
    public int FindMin(int[] nums) {
       int low=0;
       int high = nums.Length-1;
       int min = Int32.MaxValue;
       while(low<=high)
       {
            if(nums[low]<nums[high])//Which means it is perfectly sorted even after rotation
            {
                min = Math.Min(min,nums[low]);
                break;
            }
            int mid = low + (high-low)/2;
            if(nums[low]<=nums[mid]) //Get lowest value in left side and move low = mid +1 [eliminating sorted side]
            {
                min = Math.Min(min,nums[low]);
                low = mid + 1;
            }
            else //Get lowest value in right side inclusive mid(as right is sorted) and high = mid -1;[eliminating sorted side]
            {
                min = Math.Min(min,nums[mid]);
                high = mid - 1;
            }
       } 
       return min;
    }
}
