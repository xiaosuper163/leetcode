// Two Pointers

/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var moveZeroes = function(nums) {
    if (nums === null || nums.length == 0) {
        return nums;
    }
    var cursor1 = 0;
    var cursor2 = 0;
    var countZero = 0;
    while (cursor2 < nums.length) {
        if (nums[cursor2] == 0) {
            countZero++;
        } else {
            nums[cursor1++] = nums[cursor2];
        }
        cursor2++;
    }
    for (var i=nums.length-countZero; i<nums.length; i++) {
        nums[i] = 0;
    }
};