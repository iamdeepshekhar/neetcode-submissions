public class Solution {
    public int[] GetConcatenation(int[] nums) {
        List<int> list = new List<int>();
        for (int j = 0; j < 2; j++) {
            for (int i = 0; i < nums.Length; i++) {
                list.Add(nums[i]);
            }
        }
        return list.ToArray();
    }
}