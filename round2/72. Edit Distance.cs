public class Solution {
    public int MinDistance(string word1, string word2) {
        int size1 = word1.Length;
        int size2 = word2.Length;
        if (size1==0 && size2==0) return 0;
        int[][] helperArray = new int[size1+1][];
        for (int i=0; i<=size1; i++) {
            helperArray[i] = new int[size2+1];
            helperArray[i][0] = i;
        }
        for (int j=1; j<=size2; j++) {
            helperArray[0][j] = j;
        }
        for (int i=1; i<=size1; i++) {
            for (int j=1; j<=size2; j++) {
                if (word1[i-1] == word2[j-1]) helperArray[i][j] = helperArray[i-1][j-1];
                else {
                    helperArray[i][j] = Math.Min(helperArray[i-1][j-1], Math.Min(helperArray[i-1][j], helperArray[i][j-1]))+1;
                }
            }
        }
        return helperArray[size1][size2];
    }
}