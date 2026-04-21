public class Solution {
    public int Search(int[] nums, int target) {
        int l=0;
        int h=nums.Length-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            //Goal is to return the index of mid when target matches
            if(target==nums[mid])
            {
                return mid;
            }

            //Find which half of array is sorted and eliminate the portion accordingly
            if(nums[l]<=nums[mid]) //Left half is sorted
            {
                if(target>=nums[l] && target<=nums[mid])
                {
                    //Eliminate the right side of array
                    h=mid-1;
                }
                else//Eliminate the left side of array
                {
                    l = mid+1;
                }
            }
            else //Right half is sorted
            {
                if(target>=nums[mid] && target<=nums[h])
                {
                    //Eliminate the left side of array
                    l=mid+1;
                }
                else//Eliminate the right side of array
                {
                    h = mid-1;
                }
            }
        }
        return -1;
    }
}
