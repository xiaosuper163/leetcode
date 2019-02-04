# The space usage is not optimal
# We can use O(logn) extra space instead of O(n)
# Time complexity is still O(nlogn)

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, x):
#         self.val = x
#         self.left = None
#         self.right = None

class Solution:
    def sortedListToBST(self, head):
        """
        :type head: ListNode
        :rtype: TreeNode
        """
        temp = head
        nums = []
        while (temp):
            nums.append(temp.val)
            temp = temp.next
        return self.sortedArrayToBST(nums)

    def sortedArrayToBST(self, nums):
        """
        :type nums: List[int]
        :rtype: TreeNode
        """
        if len(nums) == 0:
            return
        if len(nums) == 1:
            return TreeNode(nums[0])
        if len(nums) == 2:
            node1 = TreeNode(nums[0])
            node2 = TreeNode(nums[1])
            node2.left = node1
            return node2
        if len(nums) == 3:
            node1 = TreeNode(nums[0])
            node2 = TreeNode(nums[1])
            node3 = TreeNode(nums[2])
            node2.left = node1
            node2.right = node3
            return node2
        midIndex = len(nums) // 2
        mid = TreeNode(nums[midIndex])
        left = self.sortedArrayToBST(nums[:midIndex])
        right = self.sortedArrayToBST(nums[midIndex+1:])
        mid.left = left
        mid.right = right
        return mid        