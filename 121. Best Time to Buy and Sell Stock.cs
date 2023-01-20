public class Solution {
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
			if (prices != null && prices.Length > 1)
			{
				int bestPriceToBuy = prices[0];

				for (int i = 1; i < prices.Length; i++)
				{
					maxProfit = Math.Max(maxProfit, prices[i] - bestPriceToBuy);
					bestPriceToBuy = Math.Min(bestPriceToBuy, prices[i]);
				}
			}
			return maxProfit;
    }
}
