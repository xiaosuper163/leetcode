// my solution used too much extra space

/**
 * @param {number[][]} matrix
 * @return {number[]}
 */
var spiralOrder = function(matrix) {
    if (matrix === null || matrix.length == 0) {
        return [];
    }
    var deltaRow = [0, 1, 0, -1];
    var deltaCol = [1, 0, -1, 0];
    var directionIndex = 0;
    var visited = [];
    for (var i=0; i<matrix.length; i++) {
        var tempRow = [];
        for (var j=0; j<matrix[0].length; j++) {
            tempRow.push(0);
        }
        visited.push(tempRow);
    }
    var cursorRow = 0, cursorCol = 0;
    var res = [];
    while (res.length<matrix.length*matrix[0].length) {
        res.push(matrix[cursorRow][cursorCol]);
        visited[cursorRow][cursorCol] = 1;
        var newCursorRow = cursorRow+deltaRow[directionIndex];
        var newCursorCol = cursorCol+deltaCol[directionIndex];
        if (newCursorRow>=matrix.length || newCursorCol>=matrix[0].length || newCursorRow<0 || newCursorCol<0 || visited[newCursorRow][newCursorCol] ) {
            directionIndex = (directionIndex+1)%4;
        }
        cursorRow += deltaRow[directionIndex];
        cursorCol += deltaCol[directionIndex];
    }
    return res;
};