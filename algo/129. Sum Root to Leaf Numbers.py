# divide and conquer, too slow

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def sumNumbers(self, root: TreeNode) -> int:
        if root is None:
            return 0
        return sum([int(item) for item in self.helper(root)])
        
    def helper(self, root: TreeNode) -> list():
        if root is None:
            return
        if root.left is None and root.right is None:
            return [str(root.val)]
        leftList = self.helper(root.left)
        rightList = self.helper(root.right)
        thisList = []
        if leftList: 
            thisList += [f'{root.val}{item}' for item in leftList]
        if rightList:
            thisList += [f'{root.val}{item}' for item in rightList]
        return thisList
        