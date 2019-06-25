public class Solution {
    private void Helper(int[] res, int[][]matrix, int nrow1, int nrow2, int ncol1, int ncol2, int index, int n) {
        if (index == n) return;
        if (nrow2 == nrow1 || ncol2 == ncol1) {
            for (int i=nrow1; i<=nrow2; i++) {
                for (int j=ncol1; j<=ncol2; j++) {
                    res[index++] = matrix[i][j];
                }
            }
            return;
        }
        for (int j=ncol1; j<ncol2; j++) {
            res[index++] = matrix[nrow1][j];
        }
        for (int i=nrow1; i<nrow2; i++) {
            res[index++] = matrix[i][ncol2];
        }
        for (int j=ncol2; j>ncol1; j--) {
            res[index++] = matrix[nrow2][j];
        }
        for (int i=nrow2; i>nrow1; i--) {
            res[index++] = matrix[i][ncol1];
        }
        Helper(res, matrix, nrow1+1, nrow2-1, ncol1+1, ncol2-1, index, n);
    }
    public IList<int> SpiralOrder(int[][] matrix) {
        int nrow = matrix.Length;
        if (nrow == 0) return new int[0];
        int ncol = matrix[0].Length;
        int[] res = new int[nrow*ncol];
        Helper(res, matrix, 0, nrow-1, 0, ncol-1, 0, nrow*ncol);
        return res;
    }
}