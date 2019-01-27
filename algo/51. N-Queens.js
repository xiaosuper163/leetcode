// @9 DFS

/**
 * @param {number} n
 * @return {string[][]}
 */
var solveNQueens = function(n) {
    var notValid = function(level, column, collection) {
        for (var i = 0; i < collection.length; i ++) {
            if (collection[i] == column || Math.abs(collection[i] - column) === Math.abs(i-level)) {
                return true;
            }
        }
        return false;
    }
    
    var helper = function(res, collection, level) {
        // !!! deep copy, never forget it!
        var collection = Array.from(collection);
        if (level===n) {
            res.push(collection);
            return;
        }
        
        for (var i = 0; i < n; i++) {
            // on the same column or diagnol line
            if (notValid(level, i, collection)) {
                continue;
            }
            
            collection.push(i);
            helper(res, collection, level+1);
            //console.log("this is level", level, 'position', i, 'collection', collection);
            collection.pop();
        }
    }
    
    var res = [];
    if (n==0) {
        return res;
    }
    helper(res, [], 0);
    
    //console.log(res);
    
    var finalRes = [];
    for (singleRes of res) {
        var tempSingleRes = []
        for (var i = 0; i < n; i++) {
            var tempRow = "";
            for (var j = 0; j < n; j++) {
                if (j == singleRes[i]) {
                    tempRow += "Q";
                } else {
                    tempRow += ".";
                }
            }
            tempSingleRes.push(tempRow);
        }
        finalRes.push(tempSingleRes);
    }
    
    return finalRes;
};