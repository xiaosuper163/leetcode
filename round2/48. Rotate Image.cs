public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        for (int i=0; i<(n+1)/2; i++) {
            for (int j=i; j<n-i-1; j++) {
                int temp = matrix[n-1-j][i];
                matrix[n-1-j][i] = matrix[n-1-i][n-1-j];
                matrix[n-1-i][n-1-j] = matrix[j][n-1-i];
                matrix[j][n-1-i] = matrix[i][j];
                matrix[i][j] = temp;
            }
        }
    }
}