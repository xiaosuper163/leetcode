public class Solution {
    public int NumDecodings(string s) {
        int prev1 = 1, prev2 = 1;
        if (s.Length == 0) return 0;
        if (s[0]-'0' == 0) return 0;
        if (s.Length == 1) return 1;
        for (int i=1; i<s.Length; i++) {
            int tmp = 0;
            if (s[i] == '0' && s[i-1] == '0') return 0;
            if (s[i] == '0' && (s[i-1]-'0' <= 2)) {
                tmp = prev1;
            } else if (s[i] == '0' && (s[i-1]-'0' > 2)) {
                tmp = 0;
            }  else if (s[i-1]-'0'==1 || (s[i-1]-'0'==2 &&s[i]-'0'<=6&&s[i]-'0'>=1)) {
                tmp = prev1+prev2;
            } else {
                tmp = prev2;
            }
            //Console.WriteLine(tmp);
            prev1 = prev2;
            prev2 = tmp;
        }
        return prev2;
    }
}