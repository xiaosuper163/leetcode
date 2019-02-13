# O(h) space

# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class BSTIterator(object):

    def __init__(self, root):
        """
        :type root: TreeNode
        """
        self.stack = []
        while root is not None:
            self.stack.append(root)
            root = root.left
    
    def next(self):
        """
        @return the next smallest number
        :rtype: int
        """
        if len(self.stack) == 0:
            return
        tmp = self.stack.pop()
        cand = tmp.right
        while cand is not None:
            self.stack.append(cand)
            cand = cand.left
        return tmp.val

    def hasNext(self):
        """
        @return whether we have a next smallest number
        :rtype: bool
        """
        return len(self.stack) > 0

# O(n) space?
# class BSTIterator(object):

#     def __init__(self, root):
#         """
#         :type root: TreeNode
#         """
#         self.q = []
#         self.inOrder(root, self.q)
#         self.q = self.q[::-1]
    
#     def inOrder(self, node, output):
#         if not node:
#             return
        
#         self.inOrder(node.left, output)
        
#         output.append(node.val)

#         self.inOrder(node.right, output)

#     def next(self):
#         """
#         @return the next smallest number
#         :rtype: int
#         """
#         return self.q.pop()

#     def hasNext(self):
#         """
#         @return whether we have a next smallest number
#         :rtype: bool
#         """
#         return len(self.q) > 0    
        
        
# Your BSTIterator object will be instantiated and called as such:
# obj = BSTIterator(root)
# param_1 = obj.next()
# param_2 = obj.hasNext()