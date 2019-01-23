// @9 BFS

/**
 * @param {character[][]} grid
 * @return {number}
 */
var numIslands = function(grid) {
    
    if (grid == null || grid.length == 0 || grid[0].length == 0) {
        return 0;
    }
    
    //console.log(grid);
    
    function BFS(i, j, grid) {
        var directionX = [0,0,-1,1];
        var directionY = [-1,1,0,0];
        var queue = [[i,j]];
        // !!!the position of this assignment matters!
        grid[i][j] = false;
        while (queue.length != 0) {
            var currNode = queue.shift();
            for (var k = 0; k < 4; k ++) {
                var neighborX = currNode[0] + directionX[k];
                var neighborY = currNode[1] + directionY[k];
                // out of the matrix
                if (neighborX < 0 || neighborX >= n || neighborY < 0 || neighborY >= m) {
                    continue;
                }
                // !!!use strict equal here!
                if (grid[neighborX][neighborY] === '1') {
                    queue.push([neighborX, neighborY]);
                    grid[neighborX][neighborY] = false;
                }
            }
            
        }        
    }
    
    var n = grid.length;
    var m = grid[0].length;
    
    var num_islands = 0;
    
    for (var i=0; i<n; i++) {
        for (var j=0; j<m; j++) {
            if (grid[i][j] == '1') {
                //console.log('coordinates', i, j);
                BFS(i,j,grid);
                num_islands ++;
            }
        }
    }
    
    return num_islands;
    
};