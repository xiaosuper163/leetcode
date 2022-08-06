public class Solution {
    public int MaxProfit(int k, int[] prices) {
        int n = prices.Length;
        if (n == 0 || n == 1) return 0;
        if (k >= n - 1) return Helper(prices);
        
        int[][] loc = new int[n][];
        int[][] glo = new int[n][];
        for (int i = 0; i < n; i ++) {
            loc[i] = new int[k + 1];
            glo[i] = new int[k + 1];
        }
        
        for (int i = 1; i < n; i ++) {
            for (int j = 1; j <= k; j ++) {
                int diff = prices[i] - prices[i - 1];
                loc[i][j] = Math.Max(glo[i-1][j-1] + Math.Max(0, diff), loc[i-1][j] + diff);
                glo[i][j] = Math.Max(glo[i-1][j], loc[i][j]);
            }
        }
        
        return glo[n-1][k];
    }
    
    private int Helper(int[] prices) {        
        int res = 0;
        for (int i = 1; i < prices.Length; i ++) {
            if (prices[i] > prices[i - 1]) {
                res += prices[i] - prices[i - 1];
            }
        }
        return res;
    }
}