# my solution used too much extra space
# go check Boyer-Moore Majority Vote

class Solution:
    def majorityElement(self, nums: 'List[int]') -> 'List[int]':
        if len(nums) == 1:
            return nums
        nums.sort()
        sizeThreshold = len(nums) // 3
        count = 0
        res = set()
        for i, num in enumerate(nums):
            if i-1<0:
                count += 1
                if count > sizeThreshold:
                    res.add(num)
                continue
            if num == nums[i-1]:
                count += 1
            else:
                count = 1
            if count > sizeThreshold:
                res.add(num)
        return list(res)