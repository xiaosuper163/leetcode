# O(m+n) space, Time complexity O(mn)
# O(mn) space if keeping track the index of all zero values

class Solution:
    def setZeroes(self, matrix: 'List[List[int]]') -> 'None':
        """
        Do not return anything, modify matrix in-place instead.
        """
        numRows = len(matrix)
        numColumns = len(matrix[0])
        hasZeroRows = [0]*numRows
        hasZeroColumns = [0]*numColumns
        for row_index, row in enumerate(matrix):
            if 0 in row:
                hasZeroRows[row_index] = 1
        for column_index, column in enumerate(zip(*matrix)):
            if 0 in column:
                hasZeroColumns[column_index] = 1
                
        for row_index, hasZero in enumerate(hasZeroRows):
            if hasZero:
                matrix[row_index] = [0]*numColumns
        for column_index, hasZero in enumerate(hasZeroColumns):
            if hasZero:
                for i in range(numRows):
                    matrix[i][column_index] = 0
                