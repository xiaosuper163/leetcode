public class Solution {
    public int LengthOfLastWord(string s) {
        int res = 0;
        bool startCounting = false;
        
        for (int i = s.Length - 1; i >= 0; i--) {
            if (startCounting) {
                if (s[i] != ' ') res ++;
                else return res;
            } else {
                if (s[i] != ' ') {
                    res ++;
                    startCounting = true;
                }
            }
        }
        return res;
    }
}