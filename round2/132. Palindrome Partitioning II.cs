public class Solution {
    public int MinCut(string s) {
        int size = s.Length;
        bool[,] dp_ispalindrome = new bool[size,size];
        int [] dp = new int[size];
        for (int j=0; j<size; j++) {
            dp[j] = j;
            for (int i=0; i<=j; i++) {
                if ((j-i<2 || dp_ispalindrome[i+1,j-1]) && (s[i] == s[j])) {
                    dp_ispalindrome[i,j] = true;
                    dp[j] = (i == 0) ? 0 : Math.Min(dp[j], dp[i-1] + 1);
                }
            }
        }
        return dp[size-1];
    }
}