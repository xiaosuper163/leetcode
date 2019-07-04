public class Solution {
    public bool DFS(char[][] board, string word, bool[][] isVisited, int index, int tarLen, int i, int j) {
        if (index == tarLen) return true;
        if (i>= board.Length || i<0 || j>=board[0].Length || j<0 || board[i][j] != word[index] || isVisited[i][j]) return false;
        isVisited[i][j] = true;
        if (DFS(board, word, isVisited, index+1, tarLen, i+1, j) || DFS(board, word, isVisited, index+1, tarLen, i-1, j) || DFS(board, word, isVisited, index+1, tarLen, i, j+1) || DFS(board, word, isVisited, index+1, tarLen, i, j-1)) {
            isVisited[i][j] = false;
            return true;
        }
        isVisited[i][j] = false;
        return false;
    }
    public bool Exist(char[][] board, string word) {
        if ((board.Length == 0 || board[0].Length == 0) && word.Length != 0) return false;
        if ((board.Length == 0 || board[0].Length == 0) && word.Length == 0) return false;
        bool[][] isVisited = new bool[board.Length][];
        for (int i=0; i<board.Length; i++) {
            isVisited[i] = new bool[board[0].Length];
            for (int j=0; j<board[0].Length; j++) {
                isVisited[i][j] = false;
            }
        }
        for (int i=0; i<board.Length; i++) {
            for (int j=0; j<board[0].Length; j++) {
                if (DFS(board, word, isVisited, 0, word.Length, i, j)) return true;
            }
        }
        return false;
    }
}