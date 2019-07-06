public class Solution {
    public bool IsScramble(string s1, string s2) {
        int size = s1.Length;
        bool[][][] helperArray = new bool[size][][];
        for (int i=0; i<size; i++) {
            helperArray[i] = new bool[size][];
            for (int j=0; j<size; j++) {
                helperArray[i][j] = new bool[size+1];
                helperArray[i][j][1] = (s1[i] == s2[j]);
            }
        }
        for (int len=2; len<=size; len++) {
            for (int i=0; i<=size-len; i++) {
                for (int j=0; j<=size-len; j++) {
                    for (int k=1; k<len; k++) {
                        if (((helperArray[i][j][k]) && (helperArray[i+k][j+k][len-k]))
                            || ((helperArray[i][j+len-k][k]) && (helperArray[i+k][j][len-k]))) {
                            helperArray[i][j][len] = true;   
                        }
                    }
                }
            }
        }
        return helperArray[0][0][size];
    }
}