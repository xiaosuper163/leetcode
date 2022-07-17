public class Solution {
    public void SetZeroes(int[][] matrix) {
        bool firstRowHasZero = false, firstColHasZero = false;
        int m = matrix.Length, n = matrix[0].Length;        
        for (int i = 0; i < m; i ++) {
            if (matrix[i][0] == 0) {
                firstColHasZero = true;
                break;
            }
        }
        
        for (int j = 0; j < n; j ++) {
            if (matrix[0][j] == 0) {
                firstRowHasZero = true;
                break;
            }
        }
        
        for (int i = 0; i < m; i ++) {
            for (int j = 0; j < n; j ++) {
                if (matrix[i][j] == 0) {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        
        for (int j = 1; j < n; j ++) {
            for (int i = 1; i < m; i ++) {
                if (matrix[i][0] == 0 || matrix[0][j] == 0) {
                    matrix[i][j] = 0;
                }
            }
        }
        
        if (firstRowHasZero) {
            for (int j = 0; j < n; j ++) matrix[0][j] = 0;
        }
        
        if (firstColHasZero) {
            for (int i = 0; i < m; i ++) matrix[i][0] = 0;
        }
    }
}