public class Solution {
    public void Solve(char[][] board) {
        int m = board.Length, n = board[0].Length;
        for (int i = 0; i < m; i ++) {
            Helper(board, i, 0);
            Helper(board, i, n - 1);
        }
            
        for (int j = 1; j < n - 1; j ++) {
            Helper(board, 0, j);
            Helper(board, m - 1, j);
        }
                    
        for (int i = 0; i < m; i ++) {
            for (int j = 0; j < n; j ++) {
                if (board[i][j] == '.')
                    board[i][j] = 'O';
                else
                    board[i][j] = 'X';
            }
        }
    }
    
    private void Helper(char[][] board, int i, int j) {
        if (i >= board.Length || i < 0 || j >= board[0].Length || j < 0 || board[i][j] != 'O') return;
        board[i][j] = '.';
        Helper(board, i + 1, j);
        Helper(board, i, j + 1);
        Helper(board, i - 1, j);
        Helper(board, i, j - 1);
    }
}