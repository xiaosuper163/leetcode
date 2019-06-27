public class Solution {
    public int LengthOfLastWord(string s) {
        if (s.Length == 0) return 0;
        int emptySpaceIndex = -1;
        int currLength = 0;
        int res = 0;
        for (int i=0; i<s.Length; i++) {
            if (s[i] == ' ') {
                if (emptySpaceIndex != i-1) {
                    res = currLength;
                }
                emptySpaceIndex = i;
                currLength = 0;
            } else {
                currLength++;
                res = currLength;
            }
        }
        return res;
    }
}