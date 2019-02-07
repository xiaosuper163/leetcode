# Dynamic Programming
class Solution:
    def uniquePaths(self, m: 'int', n: 'int') -> 'int':
        helper_matrix = [[0]*n]*m
        for i in range(m):
            for j in range(n):
                if i-1>=0 and j-1>=0:
                    helper_matrix[i][j] = helper_matrix[i-1][j] + helper_matrix[i][j-1]
                elif i-1>=0:
                    helper_matrix[i][j] = helper_matrix[i-1][j]
                elif j-1>=0:
                    helper_matrix[i][j] = helper_matrix[i][j-1]
                else:   # the start
                    helper_matrix[i][j] = 1
        return helper_matrix[m-1][n-1]