/**
 * @param {number[]} nums
 * @return {number}
 */
var jump = function(nums) {
    if (nums.length == 1) {
        return 0;
    }
    let max = 0;
    let currEnd = 0;
    let num_jumps = 0;
    for (let i = 0; i < nums.length - 1; i++) {
        max = Math.max(i+nums[i], max);
        if (currEnd == i) {
            num_jumps ++;
            currEnd = max;
        }
    }
    return num_jumps;
};