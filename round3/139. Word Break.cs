public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var hs = new HashSet<string>(wordDict);
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;
        
        for (int i = 1; i <= s.Length; i ++) {
            for (int j = 0; j < i; j ++) {
                if (dp[j] && hs.Contains(s.Substring(j, i - j))) {
                    dp[i] = true;
                    break;
                }
            }
        }
        
        return dp[s.Length];
    }
}