class Solution:
    def threeSum(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        
        # time complexity: O(n2)
        
        if len(nums) < 3:
            return []
        
        nums = sorted(nums)
        res = {}
        
        wc = {}
        for num in nums:
            wc[num] = wc.get(num, 0) + 1
        
        if wc.get(0) and wc.get(0) >= 3:
            res[(0, 0, 0)] = 1
        
        mid = 0
        for i in range(len(nums)):
            if nums[i]>=0:
                mid = i
                break
        
        for i in range(0, mid):
            left = nums[i]
            for j in range(mid, len(nums)):
                right = nums[j]
                target = -left-right
                if wc.get(target):
                    if (wc[target] == 1) and ((target==left) or (target==right)):
                        continue
                    if tuple(sorted([left, right, target])) not in res.keys():
                        res[tuple(sorted([left, right, target]))] = 1
        return list(res.keys())
                        
                    
                