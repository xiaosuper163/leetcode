// @9 Two Sum
// O(n) time complexity if using hashmap

/*
class Solution:
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        nums_dict = {}
        for i, num in enumerate(nums):
            nums_dict[num] = i
        for i, num in enumerate(nums):
            if (target-num) in nums_dict.keys():
                if i != nums_dict[target-num]:
                    return [i, nums_dict[target-num]]
*/

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    
    for (var i = 0; i < nums.length; i++) {
        for (var j=i+1; j< nums.length; j++) {
            if (nums[i]+nums[j] == target) {
                return [i,j];
            }
        }
    }
    
    return null;
};