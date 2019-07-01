public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 0 || matrix[0].Length == 0) return false;
        int m = matrix.Length, n = matrix[0].Length;
        if (matrix[0][0] > target || matrix[m-1][n-1] < target) return false;
        int start = 0, end = m-1, targetRow = -1;
        while (start+1<end) {
            int mid = (end-start)/2 + start;
            if (matrix[mid][0] <= target && matrix[mid][n-1] >= target) {
                targetRow = mid;
                break;
            } else if (matrix[mid][0] > target) end = mid;
            else start = mid;
        }
        if (targetRow == -1) {
            if (matrix[end][0] <= target && matrix[end][n-1] >= target) {
                targetRow = end;
            } else {
                targetRow = start;
            }
        }
        start = 0;
        end = n-1;
        while (start+1<end) {
            int mid = (end-start)/2 + start;
            if (matrix[targetRow][mid] == target) return true;
            else if (matrix[targetRow][mid] < target) start = mid;
            else end = mid;
        }
        if (matrix[targetRow][end] == target || matrix[targetRow][start] == target) return true;
        return false;
    }
}