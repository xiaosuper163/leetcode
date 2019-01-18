// @9 binary search

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var search = function(nums, target) {

    // find the index of the minimum value first
    // then do regular binary search

    var isAfterPivot = function(index) {
        return nums[index] <= nums[nums.length-1]; 
    };
    
    var start = 0;
    var end = nums.length-1;
    var pivotIndex = 0;
    
    while (start+1<end) {
        var mid = Math.floor((end-start)/2) + start;
        if (isAfterPivot(mid)) {
            end = mid;
        } else {
            start = mid;
        }
    }
    
    if (isAfterPivot(end)) {
        pivotIndex = end;
    }
    
    if (isAfterPivot(start)) {
        pivotIndex = start;
    }
    
    if (pivotIndex == 0) {                  // if there is no rotation
        start = 0;
        end = nums.length-1;
    } else if (nums[0] == target) {
        return 0;
    } else if (nums[0] < target) {
        start = 0;
        end = pivotIndex-1;
    } else {
        start = pivotIndex;
        end = nums.length - 1;
    }
    
    while (start+1<end) {
        mid = Math.floor((end-start)/2) + start;
        if (nums[mid] == target) {
            return mid;
        } else if (nums[mid] < target) {
            start = mid;
        } else {
            end = mid;
        }
    }
    
    if (nums[start] == target) {
        return start;
    }
    
    if (nums[end] == target) {
        return end;
    }
    
    return -1;
    
};

console.log(search([0,1,2,4,5,6,7], 4));