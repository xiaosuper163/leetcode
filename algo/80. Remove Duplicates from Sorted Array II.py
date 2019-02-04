# Two Pointers

class Solution:
    def removeDuplicates(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        limit = 0
        left = -1
        for i, num in enumerate(nums):
            if (left >= 0):
                if num == nums[left] and limit == 2:
                    continue
                elif num != nums[left]:
                    limit = 0
            left += 1
            nums[left] = num
            limit += 1
        return left + 1
        