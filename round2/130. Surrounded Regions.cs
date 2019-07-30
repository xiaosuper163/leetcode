public class Solution {
    private void Helper(char[][] board, int i, int j) {
        board[i][j] = '$';
        if (i-1>=0 && board[i-1][j] == 'O') Helper(board, i-1, j);
        if (i+1<board.Length && board[i+1][j] == 'O') Helper(board, i+1, j);
        if (j-1>=0 && board[i][j-1] == 'O') Helper(board, i, j-1);
        if (j+1<board[0].Length && board[i][j+1] == 'O') Helper(board, i, j+1);
    }
    
    public void Solve(char[][] board) {
        if (board.Length == 0 || board[0].Length == 0 || board[0].Length == 1) return;
        int m = board.Length, n = board[0].Length;
        for (int i=0; i<n-1; i++) {
            if (board[0][i] == 'O') Helper(board, 0, i);
            if (board[m-1][i+1] == 'O') Helper(board, m-1, i+1); 
        }
        for (int j=0; j<m-1; j++) {
            if (board[j][n-1] == 'O') Helper(board, j, n-1);
            if (board[j+1][0] == 'O') Helper(board, j+1, 0);
        }
        
        for (int i=0; i<m; i++) {
            for (int j=0; j<n; j++) {
                if (board[i][j] == '$') board[i][j] = 'O';
                else board[i][j] = 'X';
            }
        }
    }
}