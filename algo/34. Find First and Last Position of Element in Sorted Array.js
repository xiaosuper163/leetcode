/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */

// @9
// The code in this solution is very robust.
// It works for all scienarios.
// Runtime complexity: Object(log n)

var searchRange = function(nums, target) {
    var ansFirst, ansLast;
    var start = 0;
    var end = nums.length - 1;
    
    while (start + 1 < end) {
        var mid = Math.floor((end - start) / 2) + start;
        if (nums[mid] == target) {
            end = mid;
        } else if (nums[mid] > target) {
            end = mid;
        } else {
            start = mid;
        }
    }
    
    if (nums[end] == target) {
        ansFirst = end;
    }
    
    if (nums[start] == target) {
        ansFirst = start;
    }
    
    if (ansFirst == undefined) {
        ansFirst = -1;
    }
    
    start = 0;
    end = nums.length - 1;
    
    while (start + 1 < end) {
        var mid = Math.floor((end - start) / 2) + start;
        if (nums[mid] == target) {
            start = mid;
        } else if (nums[mid] > target) {
            end = mid;
        } else {
            start = mid;
        }
    }
    
    if (nums[start] == target) {
        ansLast = start;
    }
    
    if (nums[end] == target) {
        ansLast = end;
    }
    
    if (ansLast == undefined) {
        ansLast = -1;
    }
    
    return [ansFirst, ansLast];
    
};