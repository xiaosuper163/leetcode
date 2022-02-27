public class Solution {
    
    public int[] deltaX = new int[] {0,0,1,-1};
    public int[] deltaY = new int[] {1,-1,0,0};
    
    public int NumIslands(char[][] grid) {        
        if (grid.Length == 0) return 0;
        if (grid[0].Length == 0) return 0;
        
        bool[,] visited = new bool[grid.Length, grid[0].Length];
        int ret = 0;
        for (int i = 0; i < grid.Length; i ++) {
            for (int j = 0; j < grid[0].Length; j++) {
                visited[i,j] = false;
            }
        }
        
        for (int i = 0; i < grid.Length; i ++) {
            for (int j = 0; j < grid[0].Length; j++) {
                if (grid[i][j] == '1' && !visited[i,j]) {
                    BFS(i, j, grid, visited, grid.Length, grid[0].Length);
                    ret ++;
                }
            }
        }
        
        return ret;
    }
    
    private void BFS(int i, int j, char[][] grid, bool[,] visited, int m, int n) {          
        Queue<Tuple<int, int>> q = new Queue<Tuple<int, int>>();
        q.Enqueue(Tuple.Create(i,j));
        visited[i,j] = true;
        while (q.Count != 0) {
            var (x, y) = q.Dequeue();
            for (int k = 0; k < 4; k ++) {
                if (IsValid(x+deltaX[k], y+deltaY[k], m, n, grid, visited)) {
                    //Console.WriteLine($"x:{x};y:{y};i:{x+deltaX[k]};j:{y+deltaY[k]}");
                    q.Enqueue(Tuple.Create(x+deltaX[k], y+deltaY[k]));
                    visited[x+deltaX[k],y+deltaY[k]] = true;
                }
            }
        }
    }
    
    private bool IsValid(int i, int j, int m, int n, char[][] grid, bool[,] visited) {
        if (i>=m || i<0 || j>=n || j<0 || grid[i][j] == '0' || visited[i,j]) return false;
        return true;
    }
}