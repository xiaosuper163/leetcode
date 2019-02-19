/**
 * @param {number[][]} matrix
 * @param {number} target
 * @return {boolean}
 */
var searchMatrix = function(matrix, target) {
    if (matrix.length == 0) {
        return false;
    }
    if (matrix[0].length == 0) {
        return false;
    }
    let m = matrix.length;
    let n = matrix[0].length;
    
    let start = 0;
    let end = m-1;
    let rowIndex = 0;
    while (start + 1 < end) {
        let mid = Math.floor((end-start)/2) + start;
        if (matrix[mid][n-1] >= target && matrix[mid][0] <= target) {
            rowIndex = mid;
            break;
        } else if (matrix[mid][n-1] < target) {
            start = mid;
        } else {
            end = mid;
        }
    }
    if (matrix[start][n-1] >= target && matrix[start][0] <= target) {
        rowIndex = start;      
    } else if (matrix[end][n-1] >= target && matrix[end][0] <= target) {
        rowIndex = end;    
    } 
    console.log(rowIndex);
    start = 0;
    end = n-1;
    while (start + 1 < end) {
        let mid = Math.floor((end-start)/2) + start;
        if (matrix[rowIndex][mid] == target) {
            return true;
        } else if (matrix[rowIndex][mid] > target) {
            end = mid;
        } else {
            start = mid;
        }
    }
    if (matrix[rowIndex][start] == target || matrix[rowIndex][end] == target) {
        return true;
    }
    return false;
};