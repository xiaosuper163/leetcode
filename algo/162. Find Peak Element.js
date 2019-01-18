// @9 binary search

/**
 * @param {number[]} nums
 * @return {number}
 */
var findPeakElement = function(nums) {
    var start = 0;
    var end = nums.length-1;
    
    while (start+1<end) {
        var mid = Math.floor((end-start)/2) + start;
        var prev = mid>0? nums[mid-1]:-Infinity;
        var post = mid==nums.length-1? -Infinity:nums[mid+1];
        if (prev<nums[mid] && post<nums[mid]) {
            return mid;
        } else if (prev<nums[mid] && post>nums[mid]) {
            start = mid;
        } else {
            end = mid;
        }
    }

    prev = start>0? nums[start-1]:-Infinity;
    post = start==nums.length-1? -Infinity:nums[start+1];
    if (prev<nums[start] && post<nums[start]) {
        return start;
    }
    
    prev = end>0? nums[end-1]:-Infinity;
    post = end==nums.length-1? -Infinity:nums[end+1];
    if (prev<nums[end] && post<nums[end]) {
        return end;
    }
};

console.log(findPeakElement([1,2,1,3,5,6,7]));