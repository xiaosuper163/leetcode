// @9 DFS

/**
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum = function(candidates, target) {
    var helper = function(res, collection, index, remain_target) {
        if (index > candidates.length) {
            return;
        }
        
        var collection = Array.from(collection);
        if (remain_target == 0) {
            res.push(collection);
        }
        
        for (var i = index; i < candidates.length; i++) {
            if (candidates[i] > remain_target) {
                // note that it should be continue here instead of break
                continue;
            }
            
            collection.push(candidates[i]);
            // since it allows using one number multiple times,
            // we parse i instead of i+1 into the recursive function call
            helper(res, collection, i, remain_target - candidates[i]);
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