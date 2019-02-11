// Dynamic Programming

/**
 * @param {number[][]} triangle
 * @return {number}
 */
var minimumTotal = function(triangle) {
    var helper_array = Array.from(triangle);
    for (i=0; i<helper_array.length; i++) {
        for (j=0;j<helper_array[i].length;j++) {
            if (i==0 && j==0) {
             continue;
            }
            var leftSum=Infinity, rightSum=Infinity;
            if (j-1>=0) {
                leftSum = helper_array[i-1][j-1];
            }
            if (j<=i-1) {
                rightSum = helper_array[i-1][j];
            }
            helper_array[i][j] += Math.min(leftSum, rightSum);
        }
    }
    return Math.min(...helper_array[helper_array.length-1]);
};