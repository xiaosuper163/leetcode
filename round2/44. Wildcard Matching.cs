public class Solution {
    public bool IsMatch(string s, string p) {
        int m = s.Length, n = p.Length;
        if (m != 0 && n == 0) return false;
        if (m == 0 && n == 0) return true;
        bool[,] helper = new bool[m+1,n+1];
        helper[m,n] = true;
        for (int i=m-1; i>=0; i--) {
            if (p[n-1] == '*') helper[i,n] = true;
            else helper[i,n] = false;
        }
        bool nonStar = false;
        for (int i=n-1; i>=0; i--) {
            if (!nonStar && p[i]=='*') helper[m,i] = helper[m,i+1];
            else {
                helper[m,i] = false;
                nonStar = true;
            }
        }
        for (int i=m-1; i>=0; i--) {
            for (int j=n-1; j>=0; j--) {
                if (p[j] == '*') {
                    helper[i,j] = helper[i+1,j] || helper[i,j+1];
                } else if (p[j] == '?' || s[i] == p[j]) {
                    helper[i,j] = helper[i+1,j+1];
                }
            }
        }
        
        return helper[0,0];
    }
}