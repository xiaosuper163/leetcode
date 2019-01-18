// @9 Binary Search

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {boolean}
 */
var search = function(nums, target) {
    if (nums.length == 0) {
        return false;
    }
    
    var start = 0;
    var end = nums.length - 1;
    while (start + 1 < end) {
        // this is to make sure we confirm if it is the first uphill area or the second
        // we won't miss the correct result since the search process is safe
        // however the worst case runtime complexity will be O(n)
        while (nums[start] == nums[end]) {
            start ++;
        }
        
        var mid = Math.floor((end-start)/2) + start;
        if (nums[mid] == target || nums[start] == target || nums[end] == target) {
            return true;
        } else if (nums[start] <= nums[mid]) {
            if (nums[start] < target && target < nums[mid]) {
                end = mid;
            } else {
                start = mid;
            }            
        } else if (nums[mid] < nums[start]) {
            if (nums[mid] < target && target < nums[end]) {
                start = mid;
            } else {
                end = mid;
            }  
        }   
    }
    
    if (nums[start] == target || nums[end] == target) {
        return true;
    }

    return false;     
};