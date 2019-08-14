public class Solution {
    public int TitleToNumber(string s) {
        int bas = 1;
        int res = 0;
        for(int i = s.Length - 1; i >= 0; i--) {
            res += (s[i]-'A'+1) * bas;
            bas *= 26;
        }
        return res;
    }
}