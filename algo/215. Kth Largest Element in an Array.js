// @9 Array

/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var findKthLargest = function(nums, k) {
    var pivot;
    // might should shuffle the array?
    if (nums.length > 2) {
        pivot = nums[2];
    } else {
        pivot = nums[0];
    }
    var left = [];
    var mid = [];
    var right = [];
    for (var num of nums) {
        if (num < pivot) {
            left.push(num);
        } else if (num == pivot) {
            mid.push(num);
        } else {
            right.push(num);
        }
    }
    if (k <= right.length) {
        return findKthLargest(right, k);
    } else if (k - right.length <= mid.length) {
        return pivot;
    } else {
        return findKthLargest(left, k-mid.length-right.length);
    }
};