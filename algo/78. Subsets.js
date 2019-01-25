// @9 DFS

/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var subsets = function(nums) {
    
    var helper = function(res, collection, i) {
        // out of bound
        var collection = Array.from(collection);       
        if (i > nums.length) {
            return;
        }
        res.push(collection);
        
        for (var index = i; index < nums.length; index++) {
            collection.push(nums[index]);
            helper(res, collection, index+1);
            collection.pop();
        }
        
    }
    
    var res = [];
    if (nums.length == 0) {
        return [];
    }
    nums.sort();
    helper(res, [], 0);
        
    return res;
};