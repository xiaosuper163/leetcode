public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        
        char[] r = new char[s.Length];
        int k = 0;
        for(int i = 0; i < numRows; i ++) {
            if (i == 0 || i == numRows-1) {
                int j = 0;
                while (i + j < s.Length) {
                    r[k ++] = s[i + j];
                    j += (numRows * 2 - 2);
                }
            } else {
                int j1 = 0, j2 = numRows * 2 - 2 - i * 2;
                while (i + j1 < s.Length || i + j2 < s.Length) {
                    if (i + j1 < s.Length) {
                        r[k ++] = s[i + j1];
                        j1 += (numRows * 2 - 2);
                    }
                    if (i + j2 < s.Length) {
                        r[k ++] = s[i + j2];
                        j2 += (numRows * 2 - 2);
                    }
                }
            }
        }
        
        return new string(r);
    }
}