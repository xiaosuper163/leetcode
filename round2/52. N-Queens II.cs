public class Solution {
    private void Helper(int nrow, int n, bool[] col, bool[] diag1, bool[] diag2, ref int res) {
        if (nrow == n) {
            res++;
        }
        for (int ncol=0; ncol<n; ncol++) {
            if (col[ncol] || diag1[nrow+n-1-ncol] || diag2[nrow+ncol]) continue;
            col[ncol] = true;
            diag1[nrow+n-1-ncol] = true;
            diag2[nrow+ncol] = true;
            Helper(nrow+1, n, col, diag1, diag2, ref res);
            diag2[nrow+ncol] = false;
            diag1[nrow+n-1-ncol] = false;
            col[ncol] = false;
        }
    }
    public int TotalNQueens(int n) {
        bool[] col = new bool[n];
        bool[] diag1 = new bool[2*n-1];
        bool[] diag2 = new bool[2*n-1];
        int res = 0;
        Helper(0, n, col, diag1, diag2, ref res);
        return res;
    }
}