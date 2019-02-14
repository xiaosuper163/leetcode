/**
 * @param {number[][]} matrix
 * @return {void} Do not return anything, modify matrix in-place instead.
 */
var rotate = function(matrix) {
    var helper = function(matrix, rowIndex, columnIndex) {
        var temp = matrix[rowIndex][columnIndex];
        matrix[rowIndex][columnIndex] = matrix[matrix.length-1-columnIndex][rowIndex];
        matrix[matrix.length-1-columnIndex][rowIndex] = matrix[matrix.length-1-rowIndex][matrix.length-1-columnIndex];
        matrix[matrix.length-1-rowIndex][matrix.length-1-columnIndex] = matrix[columnIndex][matrix.length-1-rowIndex];
        matrix[columnIndex][matrix.length-1-rowIndex] = temp;
    }
    for (var i=0; i<Math.floor((matrix.length+1)/2); i++) {
        for (var j=i; j<matrix.length-1-i; j++) {
            helper(matrix, i, j);
        }
    }
};