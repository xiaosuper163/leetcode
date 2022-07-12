public class Solution {
    public void SolveSudoku(char[][] board) {
        Helper(board);
    }
    
    private bool Helper(char[][] board) {
        for (int i = 0; i < 9; i ++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] == '.') {
                    for (char c = '1'; c <= '9'; c++) {
                        if(IsValid(board, i, j, c)){
                            board[i][j] = c;
                            if (Helper(board)) {
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
    
    private bool IsValid(char[][] board, int i, int j, char c) {
        for (int idx = 0; idx < 9; idx ++) {
            if (board[idx][j] == c || board[i][idx] == c || board[(i / 3) * 3 + idx / 3][(j / 3) * 3 + idx % 3] == c) {
                return false;
            }
        }
        
        return true;
    }
}