public class Solution {
    public bool Exist(char[][] board, string word) {
        int m = board.Length, n = board[0].Length;
        int[][] visited = new int[m][];
        for (int i = 0; i < m; i ++) {
            visited[i] = new int[n];
        }
        
        for (int i = 0; i < m; i ++) {
            for (int j = 0; j < n; j ++) {
                if (DFSHelper(board, visited, i, j, m, n, word, 0)) {
                    return true;
                }
            }
        }
        
        return false;
    }
    
    private bool DFSHelper(char[][] board, int[][] visited, int i, int j, int m, int n, string word, int index) {
        if (index == word.Length) return true;
        if (i >= m || i < 0 || j >= n || j < 0 || board[i][j] != word[index] || visited[i][j] == 1) return false;
        
        visited[i][j] = 1;
        if (
            DFSHelper(board, visited, i + 1, j, m, n, word, index + 1) ||
            DFSHelper(board, visited, i - 1, j, m, n, word, index + 1) ||
            DFSHelper(board, visited, i, j + 1, m, n, word, index + 1) ||
            DFSHelper(board, visited, i, j - 1, m, n, word, index + 1)
        ) {
            return true;
        }
        
        visited[i][j] = 0;
        return false;        
    }
}