public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        int m = s1.Length, n=s2.Length;
        if (m + n != s3.Length) return false;
        bool[][] dp = new bool[m+1][];
        for (int i=0; i<m+1; i++) {
            dp[i] = new bool[n+1];
        }
        dp[0][0] = true;
        for (int i=1; i<m+1; i++) {
            dp[i][0] = s3.Substring(0,i).Equals(s1.Substring(0,i));
        }
        for (int j=1; j<n+1; j++) {
            dp[0][j] = s3.Substring(0,j).Equals(s2.Substring(0,j));
        }
        for (int i=1; i<m+1; i++) {
            for (int j=1; j<n+1; j++) {
                dp[i][j] = (dp[i-1][j] && s1[i-1]==s3[i+j-1]) || (dp[i][j-1] && s2[j-1]==s3[i+j-1]);
                //Console.WriteLine(string.Format("{0} {1} {2}",i, j, dp[i][j]));
            }
        }
        return dp[m][n];
    }
}