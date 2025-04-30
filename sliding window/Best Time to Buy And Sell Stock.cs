public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int buy = 0, sell = 1;
        int ans = 0;

        for (; sell < prices.Length; ++sell)
        {
            ans = Math.Max(ans, prices[sell] - prices[buy]);
            if (prices[buy] > prices[sell])
                buy = sell;
        }

        return ans;
    }
}
