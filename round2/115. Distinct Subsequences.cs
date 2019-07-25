public class Solution {
    public int NumDistinct(string s, string t) {
        int size1 = s.Length, size2 = t.Length;
        if (size1 == 0 && size2 > 0) return 0;
        if (size1 == 0 && size2 == 0) return 1;
        int[,] dp = new int[size1+1, size2+1];
        for (int i=0; i<=size1; i++) dp[i,0] = 1;
        for (int i=1; i<=size2; i++) dp[0,i] = 0;
        for (int j=1; j<=size2; j++) {
            for (int i=1; i<=size1; i++) {
                if (i<j) dp[i,j] = 0;
                else if (s[i-1] == t[j-1]) dp[i,j] = dp[i-1, j-1] + dp[i-1, j];
                else dp[i,j] = dp[i-1, j];
                //Console.WriteLine($"{i} {j} {dp[i,j]}");
            }
        }
        return dp[size1, size2];
    }
}