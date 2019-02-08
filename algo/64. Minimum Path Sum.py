# Dynamic Programming
# My solution takes a lot of extra space since the question is too confusing
# My solution is also able to find the path
# If the goal is only to find the minimum path sum, we can only save one row or column
# The space will be O(min(num_rows, num_colmns))

class Solution:
    def minPathSum(self, grid: 'List[List[int]]') -> 'int':
        num_rows = len(grid)
        num_columns = len(grid[0])
        helper_matrix = [[0 for _ in range(num_columns)] for _ in range(num_rows)]
        
        for i, row in enumerate(grid):
            for j, num in enumerate(row):
                if i-1>=0 and j-1>=0:
                    if helper_matrix[i-1][j][0] > helper_matrix[i][j-1][0]:
                        helper_matrix[i][j] = (num+helper_matrix[i][j-1][0], (i, j-1))
                    else:
                        helper_matrix[i][j] = (num+helper_matrix[i-1][j][0], (i-1, j))
                elif i-1>=0:
                    helper_matrix[i][j] = (num+helper_matrix[i-1][j][0], (i-1, j))
                elif j-1>=0:
                    helper_matrix[i][j] = (num+helper_matrix[i][j-1][0], (i, j-1))
                else:
                    helper_matrix[i][j] = (num, (-1,-1))
        return helper_matrix[num_rows-1][num_columns-1][0]
        #i = num_rows-1
        #j = num_columns-1
        #res = []
        #while (i != -1 or j != -1):
        #    res = [helper_matrix[i][j][0]] + res
        #    temp_i, temp_j = helper_matrix[i][j][1]
        #    i, j = temp_i, temp_j
        #return res