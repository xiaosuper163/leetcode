public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length, n = matrix[0].Length;
        
        int left = 0, right = m - 1, rowIdx;
        
        while (left + 1 < right) {
            int mid = (right - left) / 2 + left;
            
            if (matrix[mid][0] > target) {
                right = mid;
            } else if (matrix[mid][n-1] < target) {
                left = mid;
            } else {
                left = mid;
                right = mid;
            }
        }
        
        if (matrix[left][0] <= target && target <= matrix[left][n-1]) {
            rowIdx = left;
        } else if (matrix[right][0] <= target && target <= matrix[right][n-1]) {
            rowIdx = right;
        } else {
            return false;
        }
        
        left = 0;
        right = n - 1;
        while (left + 1 < right) {
            int mid = (right - left) / 2 + left;
            
            if (matrix[rowIdx][mid] == target) {
                return true;
            } else if (matrix[rowIdx][mid] > target) {
                right = mid;
            } else {
                left = mid;
            }
        }
        
        if (matrix[rowIdx][left] == target || matrix[rowIdx][right] == target) return true;
        return false;
    }
}