public class SolutionMaxProfit
{
    public int MaxProfit(int[] prices)
    {
        int ans = 0;
        int l = 0;
        int r = 1;
        int len = prices.Length;

        while (r < len)
        {
            if (prices[r] > prices[l])
            {
                ans = Math.Max(ans, prices[r] - prices[l]);
            }
            else
            {
                l = r;
            }
            r++;
        }

        return ans;
    }
}
