# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def rotateRight(self, head, k):
        """
        :type head: ListNode
        :type k: int
        :rtype: ListNode
        """
        if head is None:
            return head
        dummy = ListNode(0)
        dummy.next = head
        cursor = dummy
        size = 0
        while cursor.next != None:
            cursor = cursor.next
            size += 1
        end = cursor
        targetIndex = size - k % size
        cursor = dummy
        while targetIndex > 0:
            cursor = cursor.next
            targetIndex -= 1
        end.next = dummy.next
        newHead = cursor.next
        cursor.next = None
        return newHead
        