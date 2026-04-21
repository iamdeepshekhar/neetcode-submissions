public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> finalList = new List<List<int>>();
        //HashSet<List<int>> set = new HashSet<List<int>>();
        //HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        List<int> tripletsList = new List<int>();
                        int[] arr = new int[] { nums[i], nums[j], nums[k] };
                        Array.Sort(arr);
                        foreach (int item in arr)
                        {
                            tripletsList.Add(item);
                        }
                        if (!finalList.Any(t => t.SequenceEqual(tripletsList)))
                        {
                            finalList.Add(tripletsList);
                        }

                    }
                }
            }

        }
        return finalList;
    }
}