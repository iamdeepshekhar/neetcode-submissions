public class Solution {
    public int FindMin(int[] nums) {
        int min = 999999;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]<min)
            {
                min = nums[i];
            }
        }
        return min;
    }
}
