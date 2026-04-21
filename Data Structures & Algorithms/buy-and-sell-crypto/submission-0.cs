public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        for(int i = 0; i<prices.Length;i++)
        {
            int j = prices.Length;
            while(j>i)
            {
                if(prices[j]>prices[i])
                {
                    int currentProfit = prices[j]-prices[i];
                    if(currentProfit>maxProfit)
                    {
                        maxProfit = currentProfit;
                    }
                }
                j--;
            }
        }
        return maxProfit;
    }
}
