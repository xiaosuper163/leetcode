// @9 Array

/**
 * @param {number[]} nums
 * @return {number}
 */
var maxSubArray = function(nums) {
    var sum = 0;
    var minSum = 0;
    var res = -Infinity;
    for (var i = 0; i < nums.length; i++) {
        sum += nums[i];
        if (sum - minSum > res) {
            res = sum - minSum;
        }
        if (sum < minSum) {
            minSum = sum;
        }
    }
    return res;
};