// @9 DFS

/**
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum2 = function(candidates, target) {
    // 1. definition
    var helper = function(res, collection, index, remain_target) {
        if (index > candidates.length) {
            return;
        }
        
        var collection = Array.from(collection);
        // 3. exit
        if (remain_target == 0) {
            res.push(collection);
        }
        
        // 2. split
        for (var i = index; i < candidates.length; i++) {
            if (candidates[i] > remain_target) {
                // note that it should be continue here instead of break
                continue;
            }
            
            if (i!=index && candidates[i] === candidates[i-1]) {
                continue;
            }
            
            collection.push(candidates[i]);
            helper(res, collection, i+1, remain_target - candidates[i]);
            collection.pop();
        }
    }
    
    var res = [];
    if (candidates.length == 0) {
        return res;
    }
    
    candidates.sort();
    helper(res, [], 0, target);
    return res;
};