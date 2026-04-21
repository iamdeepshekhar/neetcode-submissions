public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] finalArray = new int[nums.Length];
        int totalMultiplied = 1;
        int countZero = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]!=0)
            {
            totalMultiplied = nums[i]*totalMultiplied;
            }
            else
            {
                //finalArray[i] = nums[i];
                countZero += 1;
            }
        }
        for(int i=0;i<nums.Length;i++)
        {
            if(countZero<1)
            {
            if(nums[i]!=0)
            {finalArray[i] = totalMultiplied/nums[i];}
            else
            {
                finalArray[i] = nums[i];
            }
            }
            else if(countZero==1)
            {
                if(nums[i]!=0)
                {
                    finalArray[i] =0;
                }
                else
                {
                    finalArray[i] = totalMultiplied;
                }
            }
            else
            {
                finalArray[i]= 0;
            }

        }
        return finalArray;
    }
}
