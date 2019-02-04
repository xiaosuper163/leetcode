// @9 Two Pointers

/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var sortColors = function(nums) {
    var swap = function(nums, index1, index2) {
        if (index1==index2) {
            return;
        }
        var temp = nums[index2];
        nums[index2] = nums[index1];
        nums[index1] = temp;
    }
    var left = 0;
    var right = nums.length-1;
    var cursor = 0;
    while (cursor <= right) {
        if (nums[cursor] == 1) {
            cursor++;
        } else if (nums[cursor] == 0) {
            swap(nums, left, cursor);
            cursor++;
            left++;
        } else {
            swap(nums, right, cursor);
            // do not increment cursor here since we don't know
            // what the new value is after swapping
            right--;
        }        
    }
};