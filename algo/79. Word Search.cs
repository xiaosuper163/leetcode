// DFS and backtracking

public class Solution {
    public bool[,] visited;
    public bool Exist(char[,] board, string word) {
        if (word.Length == 0) {
            return true;
        }
        int m = board.GetLength(0);
        int n = board.GetLength(1);
        visited = new bool[m,n];
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i,j].Equals(word[0]) && Helper(board, word, 0, i, j)) {
                    return true;
                }
            }
        }
        return false;
    }
    
    public bool Helper(char[,] board, string word, int index, int i, int j) {
        if (index == word.Length) {
            return true;
        }
        if (i<0 || i>=board.GetLength(0) || j<0 || j>=board.GetLength(1)
            || !board[i,j].Equals(word[index]) || visited[i,j]) {
            return false;
        }
        visited[i,j] = true;
        if (Helper(board, word, index+1, i+1, j)
           || Helper(board, word, index+1, i-1,j)
           || Helper(board, word, index+1, i, j+1)
           || Helper(board, word, index+1, i, j-1)) {
            return true;
        }
        visited[i,j] = false;
        return false;
    }
}