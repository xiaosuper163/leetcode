public class Solution {
    public int[][] GenerateMatrix(int n) {
        int width = n;
        int[][] res = new int[width][];
        for (int i=0; i<width; i++) res[i] = new int[width];
        int curr = 1;
        for (int offset = 0; offset < n/2; offset++) {
            for (int i=offset; i<width-offset-1; i++) res[offset][i] = curr++;
            for (int i=offset; i<width-offset-1; i++) res[i][width-offset-1] = curr++;
            for (int i=width-offset-1; i>offset; i--) res[width-offset-1][i] = curr++;
            for (int i=width-offset-1; i>offset; i--) res[i][offset] = curr++;
        }
        if (n%2==1) res[n/2][n/2] = n*n;
        return res;
    }
}