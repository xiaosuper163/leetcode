class Solution:
    def threeSumClosest(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: int
        """
        
        if len(nums) < 3:
            return []
        
        nums.sort()
        
        minDist = None
        closeSum = 0
        
        for i in range(len(nums)-2):
            currNum = nums[i]
            left = i+1
            right = len(nums)-1
            while (left!=right):
                currSum = currNum + nums[left] + nums[right]
                currDist = abs(currSum - target)
                if minDist is None:
                    minDist = currDist
                    closeSum = currSum
                elif currDist < minDist:
                    minDist = currDist
                    closeSum = currSum
                
                if currSum == target:
                    return currSum
                elif currSum < target:
                    left += 1
                elif currSum > target:
                    right -= 1
        return closeSum
        
        
        