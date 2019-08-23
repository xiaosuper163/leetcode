public class Solution {
    private void Helper(char[][] grid, bool[][] visited, int i, int j, int m, int n) {
        visited[i][j] = true;
        if (i+1<m && !visited[i+1][j] && grid[i+1][j] == '1') Helper(grid, visited, i+1, j, m, n);
        if (i-1>=0 && !visited[i-1][j] && grid[i-1][j] == '1') Helper(grid, visited, i-1, j, m, n);
        if (j+1<n && !visited[i][j+1] && grid[i][j+1] == '1') Helper(grid, visited, i, j+1, m, n);
        if (j-1>=0 && !visited[i][j-1] && grid[i][j-1] == '1') Helper(grid, visited, i, j-1, m, n);
    }
    public int NumIslands(char[][] grid) {
        int m = grid.Length;
        if (m == 0) return 0;
        int n = grid[0].Length;
        if (n == 0) return 0;
        int res = 0;
        bool[][] visited = new bool[m][];
        for (int i=0; i<m; i++) {
            visited[i] = new bool[n];
            for (int j=0; j<n; j++) {
                visited[i][j] = false;
            }
        }
        for (int i=0; i<m; i++) {
            for (int j=0; j<n; j++) {
                if (grid[i][j] == '1' && !visited[i][j]) {
                    Helper(grid, visited, i, j, m, n);
                    res++;
                }
            }
        }
        return res;
    }
}