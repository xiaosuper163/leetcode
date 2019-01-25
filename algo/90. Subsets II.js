// @9 DFS

/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var subsetsWithDup = function(nums) {
    var helper = function(res, collection, index) {
        if (index > nums.length) {
            return;
        }
        
        
        var collection = Array.from(collection);
        res.push(collection);
                
        for (var i = index; i < nums.length; i++) {

            // when we iterate on the next element
            // it must not as same as the previous element at the same level
            // otherwise it will produce the duplicates
            // this is the only difference between Subsets I and Subsets II
            if (i!=index && nums[i]==nums[i-1]) {
                continue;
            }
            
            collection.push(nums[i]);
            helper(res, collection, i+1);
            collection.pop();
        }
    };
    
    var res = [];
    if (nums.length == 0) {
        return res;
    }
    
    nums.sort();
    helper(res, [], 0);
    return res;
};