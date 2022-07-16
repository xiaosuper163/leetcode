public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] res = new int[n][];
        for (int i = 0; i < n; i ++) res[i] = new int[n];
        int k = 1, offsetX = 0, offsetY = 0;
        
        while (offsetX < (n+1)/2 && offsetY < (n+1)/2) {
            for (int j = offsetY; j < n - offsetY; j ++) {
                res[offsetX][j] = k ++;
            }

            for (int i = offsetX + 1; i < n - offsetX - 1; i ++) {
                res[i][n - offsetY - 1] = k ++;
            }

            if (offsetX == n / 2) break;

            for (int j = n - offsetY - 1; j >= offsetY; j --) {
                res[n - offsetX - 1][j] = k ++;
            }
            
            for (int i = n - offsetX - 2; i >= offsetX + 1; i --) {
                res[i][offsetY] = k ++;
            }
            
            offsetX ++;
            offsetY ++;
        }
        
        return res;
    }
}