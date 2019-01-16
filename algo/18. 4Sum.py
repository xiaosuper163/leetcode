class Solution:
    def fourSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[List[int]]
        """
        
        # Time complexity: O(n^3)

        if len(nums) < 4:
            return []

        nums.sort()

        res = dict()

        for i in range(len(nums)-3):
            for j in range(i+1, len(nums)-2):
                left = j+1
                right = len(nums)-1
                num_i = nums[i]
                num_j = nums[j]
                #print("i =",i, "j =", j)
                while left != right:
                    num_left = nums[left]
                    num_right = nums[right]
                    currSum = num_i + num_j + num_left + num_right
                    if currSum == target and (num_i, num_j, num_left, num_right) not in res.keys():
                        res[(num_i, num_j, num_left, num_right)] = 1
                        left += 1
                    elif currSum == target:
                        left += 1
                    elif currSum < target:
                        left += 1
                    elif currSum > target:
                        right -= 1
                    #print("left = ",left," right =",right)
        return list(res.keys())



print(Solution().fourSum([1,0,-1,0,-2,2], 0))