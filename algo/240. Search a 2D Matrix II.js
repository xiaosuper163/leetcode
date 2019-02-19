/**
 * @param {number[][]} matrix
 * @param {number} target
 * @return {boolean}
 */
var searchMatrix = function(matrix, target) {
    if (matrix.length == 0 || matrix[0].length == 0) {
        return false;
    }
    let m = 0;
    let n = matrix[0].length-1;
    while (m < matrix.length && n >= 0) {
        if (matrix[m][n] == target) {
            return true;
        } else if (matrix[m][n] < target) {
            m += 1;
        } else {
            n -= 1;
        }
    }
    return false;
};