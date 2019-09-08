public class Solution {
    public bool SearchMatrix(int[,] matrix, int target) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        if (m == 0 || n == 0) return false;
        if (matrix[0,0] > target || matrix[m-1,n-1] < target) return false;
        int x = m-1, y = 0;
        while (true) {
            if (matrix[x,y] == target) return true;
            else if (matrix[x,y] < target) y++;
            else x--;
            if (x < 0 || y >= n) return false;
        }
        return false;
    }
}