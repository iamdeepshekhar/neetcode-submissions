public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool hasDuplicate = false;
        Dictionary<int,int> dict = new Dictionary<int,int>();
     for(int i=0;i<nums.Length;i++)
     {
        if(!dict.ContainsKey(nums[i]))
        {
            dict.Add(nums[i],nums[i]);
        }
        else
        {
            return true;
        }
     }
        return hasDuplicate;
    }
}