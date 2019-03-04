class Solution(object):
    def climbStairs(self, n):
        """
        :type n: int
        :rtype: int
        """
        if n==1:
            return 1
        if n==2:
            return 2
        prev1 = 1
        prev2 = 2
        for i in range(n-2):
            temp = prev1+prev2
            prev1 = prev2
            prev2 = temp
        return prev2