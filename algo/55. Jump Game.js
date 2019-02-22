// O(n) time complexity solution
/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canJump = function(nums) {
    if (!nums.length || nums.length == 1) {
        return true;
    }
    if (nums[0] == 0) {
        return false;
    }
    let max = nums[0];
    for (let i = 1; i < nums.length; i++) {
        if (max >= i) {
            max = Math.max(i+nums[i], max);
        }
    }
    return max >= nums.length - 1;
};

// My original solution
// Way too inefficient
/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canJump = function(nums) {
    var helper_dict = {};
    var helper = function(index, nums) {
        if (index>=nums.length-1) {
            return true;
        }
        if (helper_dict[index]) {
            return false;
        }
        var i = nums[index];
        while (i>0) {
            if (helper(index+i, nums)) {
                return true;
            }
            i--;
        }
        helper_dict[index] = 1;
        return false;
    }
    return helper(0, nums);
};