# Two Pointers

class Solution:
    def removeDuplicates(self, nums):
        """
        :type nums: List[int]
        :rtype: int
        """
        left = -1
        for i, num in enumerate(nums):
            if left >= 0:
                if num == nums[left]:
                    continue
            left += 1
            nums[left] = num
        return left + 1

# class Solution(object):
#     def removeDuplicates(self, nums):
#         """
#         :type nums: List[int]
#         :rtype: int
#         """
#         i = 0
#         while(i<len(nums)-1):
#             if nums[i] == nums[i+1]:
#                 nums.pop(i)
#             else:
#                 i += 1
#         return len(nums)