public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] finalIndices = new int[2];
    for(int i=0;i<nums.Length;i++)
    {
        for(int j = i+1;j<nums.Length;j++)
        {
            if(nums[i]+nums[j] == target)
            {
                finalIndices = [i,j];
            }
        }
    }
    return finalIndices;
    }
}
