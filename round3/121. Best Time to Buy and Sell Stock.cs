public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0], res = 0;
        for (int i = 1; i < prices.Length; i++) {
            res = Math.Max(res, prices[i] - minPrice);
            minPrice = Math.Min(minPrice, prices[i]);
        }
        return res;
    }
}