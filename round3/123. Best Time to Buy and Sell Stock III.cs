public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length, k = 2;
        // localMaxProfit[i][j] denotes the maximum profit with at most j transactions and selling on day i
        // globalMaxProfit[i][j] denotes the maximum profit with at most j transactions. no restriction on the transaction condition on day i
        int[][] localMaxProfit = new int[n][];
        int[][] globalMaxProfit = new int[n][];
        
        for (int i = 0; i < n; i ++) {
            localMaxProfit[i] = new int[k + 1];
            globalMaxProfit[i] = new int[k + 1];
        }
        
        for (int i = 1; i < n; i ++) {
            for (int j = 1; j <= k; j ++) {
                int diff = prices[i] - prices[i - 1];
                localMaxProfit[i][j] = Math.Max(localMaxProfit[i - 1][j] + diff, globalMaxProfit[i - 1][j - 1] + Math.Max(diff, 0));
                globalMaxProfit[i][j] = Math.Max(globalMaxProfit[i-1][j], localMaxProfit[i][j]);
            }
        }
        
        return globalMaxProfit[n - 1][2];
    }
}