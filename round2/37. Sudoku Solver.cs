public class Solution {
    private bool IsValid(char[][] board, int i, int j, char c) {
        for (int index = 0; index < 9; index++) {
            if (board[i][index] == c) return false;
            if (board[index][j] == c) return false;
            if (board[((int)i/3)*3+index/3][((int)j/3)*3+index%3] == c) return false;
        }
        return true;
    }
    
    private bool BackTrack(char[][] board) {
        for (int i=0; i<9; i++) {
            for (int j=0; j<9; j++) {
                if (board[i][j] == '.') {
                    for (char c='1'; c<='9'; c++) {
                        if (IsValid(board, i, j, c)) {
                            board[i][j] = c;
                            if (BackTrack(board)) {
                                return true;
                            } else {
                                board[i][j] = '.';
                            }
                        } 
                    }
                    return false;
                }
            }
        }
        return true;
    }
    
    public void SolveSudoku(char[][] board) {
        BackTrack(board);
    }
}