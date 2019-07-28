public class Solution {
    public int MaxProfit(int[] prices) {
        int min = int.MaxValue, res=0;
        foreach(int price in prices) {
            min = Math.Min(min, price);
            res = Math.Max(res, price - min);
        }
        return res;
    }
}