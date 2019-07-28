public class Solution {
    public int MaxProfit(int[] prices) {
        int numMaxTxns = 2, numDays = prices.Length;
        if (numDays == 0 || numDays == 1) return 0;
        int[,] local = new int[numDays, numMaxTxns+1];
        int[,] glob = new int[numDays, numMaxTxns+1];
        for (int j=0; j<=numMaxTxns; j++) {
            local[0, j] = 0;
            glob[0, j] = 0;
        }
        for (int i=1; i<numDays; i++) {
            local[i, 0] = 0;
            glob[i, 0] = 0;
            int diff = prices[i] - prices[i-1];
            for (int j=1; j<=numMaxTxns; j++) {
                local[i, j] = Math.Max(local[i-1, j]+diff, glob[i-1, j-1]+Math.Max(diff, 0));
                glob[i, j] = Math.Max(glob[i-1, j], local[i, j]);
            }
        }
        /*for (int i=0; i<numDays; i++) {
            StringBuilder sb = new StringBuilder();
            for (int j=0; j<=numMaxTxns; j++) {
                sb.Append(glob[i,j]);
                sb.Append(' ');
            }
            Console.WriteLine(sb.ToString());
        }*/
        return glob[numDays-1,numMaxTxns];
    }
}