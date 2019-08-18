public class Solution {
    public int MaxProfit(int k, int[] prices) {
        if (prices.Length == 0) return 0;
        if (k>=prices.Length) {
            return Helper(prices);
        }
        int[] l = new int[k+1];
        int[] g = new int[k+1];
        
        for (int i=0; i<prices.Length-1; i++) {
            int diff = prices[i+1] - prices[i];
            for (int j=k; j>=1; j--) {
                l[j] = Math.Max(g[j-1]+Math.Max(diff, 0), l[j]+diff);
                g[j] = Math.Max(l[j], g[j]);
            }
        }
        return g[k];
    }
    private int Helper(int[] prices) {
        int res = 0;
        for (int i=1; i<prices.Length; i++) {
            if (prices[i] > prices[i-1]) {
                res += prices[i] - prices[i-1];
            }
        }
        return res;
    }
}