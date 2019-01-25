import math

class Solution:
    def isPalindrome(self, x):
        """
        :type x: int
        :rtype: bool
        """
        if x<0:
            return False
        
        if x==0:
            return True
        
        length = int(math.log10(x)) + 1
        
        while length>1:
            last = x%10
            #print('last: {}'.format(last))
            first = x//(10**(length-1))
            #print('first: {}'.format(first))
            if last != first:
                return False
            x = (x-first*(10**(length-1))-last)/10
            #print(x)
            length -= 2
            
        return True