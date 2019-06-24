public class Solution {
    private void helper(int nrow, int n, List<IList<string>> res, char[][] matrix, bool[] col, bool[] diag1, bool[] diag2) {
        if (nrow == n) {
            List<string> temp = new List<string>();
            for (int i=0; i<n; i++) {
                temp.Add(new string(matrix[i]));
            }
            res.Add(temp);
        }
        for (int ncol=0; ncol<n; ncol++) {
            if (col[ncol] || diag1[nrow+n-1-ncol] || diag2[nrow+ncol]) continue;
            matrix[nrow][ncol] = 'Q';
            col[ncol] = true;
            diag1[nrow+n-1-ncol] = true;
            diag2[nrow+ncol] = true;
            helper(nrow+1, n, res, matrix, col, diag1, diag2);
            diag2[nrow+ncol] = false;
            diag1[nrow+n-1-ncol] = false;
            col[ncol] = false;
            matrix[nrow][ncol] = '.';
        }        
    }
    public IList<IList<string>> SolveNQueens(int n) {
        char [][] matrix = new char[n][];
        for (int i=0; i<n; i++) {
            matrix[i] = new char[n];
            for (int j=0; j<n; j++) {
                matrix[i][j] = '.';
            }
        }
        bool[] col = new bool[n];
        bool[] diag1 = new bool[2*n-1];
        bool[] diag2 = new bool[2*n-1];
        var res = new List<IList<string>>();
        helper(0, n, res, matrix, col, diag1, diag2);
        return res;
    }
}