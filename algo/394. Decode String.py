# @9 data structure stack

class Solution:
    def decodeString(self, s: 'str') -> 'str':
        if len(s) == 0:
            return ''
        stack = []
        tempStr = ''
        i = 0
        while i < len(s):
            # print('', stack)
            if ord(s[i]) >= 48 and ord(s[i]) <= 57:
                while s[i] != '[':
                    tempStr += s[i]
                    i += 1
                stack.append(int(tempStr))
                tempStr = ''
            elif s[i] == '[':
                i += 1
            elif s[i] == ']':
                strSlice = stack.pop()
                secondLast = stack.pop()
                while (type(secondLast) != int):
                    strSlice = secondLast + strSlice
                    secondLast = stack.pop()
                stack.append(strSlice*secondLast)
                i += 1
            else:
                while s[i].isalpha():
                    tempStr += s[i]
                    i += 1
                    if i == len(s):
                        break
                stack.append(tempStr)
                tempStr = ''
        return ''.join(strSlice for strSlice in stack)