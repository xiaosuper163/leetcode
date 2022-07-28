public class Solution {
    public int MinCut(string s) {
        int n = s.Length;
        
        bool[][] isPalindrome = new bool[n][];
        int[] dp = new int[n];
        
        for (int i = 0; i < n; i ++) {
            isPalindrome[i] = new bool[n];
            isPalindrome[i][i] = true;
        }
        
        for (int j = 0; j < n; j ++) {
            dp[j] = j;
            for (int i = 0; i <= j; i ++) {
                isPalindrome[i][j] = ((j - i < 2) || isPalindrome[i+1][j-1]) && (s[i] == s[j]);
                if (isPalindrome[i][j])
                    dp[j] = i == 0 ? 0 : Math.Min(dp[j], dp[i-1] + 1);
            }
        }
        
        return dp[n-1];
    }
}