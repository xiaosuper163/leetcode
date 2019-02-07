# brute force solution
class Solution:
    def isValidSudoku(self, board: 'List[List[str]]') -> 'bool':      
        for i in range(3):
            for j in range(3):
                if self.hasDuplicate([item for sublist in list(zip(*board[3*i:3*i+3]))[3*j:3*j+3] for item in sublist]):
                    return False
        for i in range(9):
            if self.hasDuplicate(board[i]):
                return False
            if self.hasDuplicate([item for sublist in list(zip(*board))[i] for item in sublist]):
                return False
        return True
    def hasDuplicate(self, lst: 'List[str]') -> 'bool':
        helper_dict = {}
        for item in lst:
            if item != '.' and helper_dict.get(item) is not None:
                return True
            elif item != '.':
                helper_dict[item] = 1
        return False
                