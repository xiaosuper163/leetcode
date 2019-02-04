# Two Pointers

class Solution:
    def minSubArrayLen(self, s, nums):
        """
        :type s: int
        :type nums: List[int]
        :rtype: int
        """
        res = float("inf")
        left = 0
        right = 0
        rangeSum = 0
        while right <= len(nums):
            if rangeSum >= s:
                res = min(res, right-left)
                rangeSum -= nums[left]
                left += 1
            elif right < len(nums):
                rangeSum += nums[right]
                right += 1
            else:
                right += 1
        if res == float("inf"):
            return 0
        else:
            return res