public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        for(int i=0; i<heights.Length;i++)
        {
            int j = heights.Length - 1;
            while(j>i)
            {
                int heightAllowed = Math.Min(heights[i],heights[j]);
                int breadth = Math.Abs(j-i);
                int area = heightAllowed* breadth;
                if(area>maxArea)
                {
                    maxArea = area;
                }
                j--;
            }
        }
        return maxArea;
    }
}
