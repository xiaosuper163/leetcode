# my solution used too much extra space

class Solution:
    def majorityElement(self, nums: 'List[int]') -> 'int':
        wc = dict()
        for num in nums:
            wc[num] = wc.get(num, 0) + 1
        size = len(nums)
        for k,v in wc.items():
            if v > size//2:
                return k