public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var res = new List<int>();
        
        int m = matrix.Length;
        int n = matrix[0].Length;
        
        int offsetX = 0, offsetY = 0;
        
        while (offsetX < (m+1)/2 && offsetY < (n+1)/2) {
            
            if (offsetY * 2 + 1 == n) {
                for (int i = offsetX; i < m - offsetX; i ++) {
                    res.Add(matrix[i][n-offsetY-1]);
                } 
            } else if (offsetX * 2 + 1 == m) {
                for (int j = offsetY; j < n - offsetY; j ++) {
                    res.Add(matrix[offsetY][j]);
                }
            } else {
                for (int j = offsetY; j < n - offsetY - 1; j ++) {
                    res.Add(matrix[offsetY][j]);
                }
                for (int i = offsetX; i < m - offsetX - 1; i ++) {
                    res.Add(matrix[i][n-offsetY-1]);
                }
                for (int j = n - offsetY - 1; j > offsetY; j --) {
                    res.Add(matrix[m-offsetX-1][j]);
                }
                for (int i = m - offsetX - 1; i > offsetX; i --) {
                    res.Add(matrix[i][offsetY]);
                }
            }            
            
            offsetX ++;
            offsetY ++;
        }
        
        return res;
    }
}
