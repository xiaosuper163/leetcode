public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length;
        bool rowFlag = false, colFlag = false;
        for (int i=0; i<m; i++) {
            if (matrix[i][0] == 0) {
                colFlag = true;
                break;
            }
        }
        for (int j=0; j<n; j++) {
            if (matrix[0][j] == 0) {
                rowFlag = true;
                break;
            }
        }
        for (int i=1; i<m; i++) {
            for (int j=1; j<n; j++) {
                if (matrix[i][j] == 0) {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        for (int i=1; i<m; i++) {
            for (int j=1; j<n; j++) {
                if (matrix[i][0] == 0 || matrix[0][j] == 0) {
                    matrix[i][j] = 0;
                }
            }
        }
        for (int i=0; i<m; i++) {
            if (colFlag) matrix[i][0] = 0;
        }
        for (int j=0; j<n; j++) {
            if (rowFlag) matrix[0][j] = 0;
        }
    }
}