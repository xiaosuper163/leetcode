// @9 DFS

/**
 * @param {number[]} nums
 * @return {number[][]}
 */
var permuteUnique = function(nums) {
    var helper = function(res, nums, collection, size) {
        var collection = Array.from(collection);
        
        if (size == nums.length) {
            res.push(collection);
            return;
        }
        
        for (var i=0; i<nums.length; i++) {
                                   
            // on the same level, don't use the same number twice
            if (i>0 && nums[i] == nums[i-1] && !visited[i-1]) {
                continue;
            }
            
            // if we have visisted this node
            if (visited[i]) {
                continue;
            }
                        
            collection.push(nums[i]);
            visited[i] = 1;
            helper(res, nums, collection, size+1);
            collection.pop();
            visited[i] = 0;
        }
    };
       
    var res = [];
    
    if (nums.length == 0) {
        return res;
    }
    
    // use an array to store if a specific node has been visited
    var visited = [];
    for (var i=0; i<nums.length; i++) {
        visited.push(0);
    }
    
    nums.sort();
    helper (res, nums, [], 0);
    return res;
};