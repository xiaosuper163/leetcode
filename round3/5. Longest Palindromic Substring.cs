public class Solution {
    public string LongestPalindrome(string s) {
        string res = s.Substring(0, 1);
        int[][] dp = new int[s.Length][];
        for (int i = 0; i < s.Length; i ++) {
            dp[i] = new int[s.Length];
            dp[i][i] = 1;
        }
        
        for (int i = 0; i < s.Length; i ++) {
            for (int j = 0; j < i; j ++) {
                if ((i == j + 1 || dp[j+1][i-1] == 1) && s[i] == s[j]) {
                    dp[j][i] = 1;
                    res = (i - j + 1) > res.Length ? s.Substring(j, i-j+1) : res;
                } else {
                    dp[j][i] = 0;
                }
            }
        }
        
        return res;
    }
}


// This will work
// x
// xx
// xxx
// xxxx
// xxxxx

// This won't work
// xxxxx
//  xxxx
//   xxx
//    xx
//     x