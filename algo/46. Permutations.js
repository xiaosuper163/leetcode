// @9 DFS

/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var permute = function(nums) {
    var helper = function(res, collection, index) {
        var collection = Array.from(collection);
        
        if (index == nums.length) {
            res.push(collection);
            return;
        }
        
        for (var i=0; i<nums.length; i++) {
            if (collection.includes(nums[i])) {
                continue;
            }
            collection.push(nums[i]);
            helper(res, collection, index+1);
            collection.pop();
        }
    };
    
    
    var res = [];
    
    helper (res, [], 0);
    return res;
    
};
