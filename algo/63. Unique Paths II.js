// Dynamic Programming
/**
 * @param {number[][]} obstacleGrid
 * @return {number}
 */
var uniquePathsWithObstacles = function(obstacleGrid) {
    var m = obstacleGrid.length;
    var n = obstacleGrid[0].length;
    var helper_matrix = [];
    var dummy_row = [];
    for (var i=0; i<n; i++) {
        dummy_row.push(0);
    }
    for (var i=0; i<m; i++) {
        helper_matrix.push(Array.from(dummy_row));
    }
    for (var i=0; i<m; i++) {
        for (var j=0; j<n; j++) {
            if (obstacleGrid[i][j] == 1) {
                helper_matrix[i][j] = 0;
            } else if (i-1>=0 && j-1>=0) {
                helper_matrix[i][j] = helper_matrix[i-1][j] + helper_matrix[i][j-1];
            } else if (i-1>=0) {
                helper_matrix[i][j] = helper_matrix[i-1][j]
            } else if (j-1>=0) {
                helper_matrix[i][j] = helper_matrix[i][j-1]
            } else {
                helper_matrix[i][j] = 1
            }
        }
    }
    return helper_matrix[m-1][n-1];
};