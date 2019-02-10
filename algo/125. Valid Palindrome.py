class Solution:
    def isPalindrome(self, s: 'str') -> 'bool':
        i = 0
        j = len(s)-1
        while i<j and i<len(s) and j>=0:
            while s[i].isalnum() != True:
                i += 1
                if i >= len(s):
                    return True
            while s[j].isalnum() != True:
                j -= 1
                if j < 0:
                    return True
            if s[i].lower() != s[j].lower():
                return False
            i += 1
            j -= 1
        return True