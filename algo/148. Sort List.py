# Linked List & Merge Sort

# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def sortList(self, head: 'ListNode') -> 'ListNode':
        if head is None or head.next is None:
            return head
        breakPoint = ListNode(0)
        breakPoint.next = head
        tortois = head
        rabbit = head
        left = head
        while rabbit.next is not None:
            tortois = tortois.next
            breakPoint = breakPoint.next
            rabbit = rabbit.next.next
            if rabbit is None:
                break
        breakPoint.next = None
        leftHead = self.sortList(left)
        rightHead = self.sortList(tortois)
        return self.merge(leftHead, rightHead)
    def merge(self, leftHead: 'ListNode', rightHead: 'ListNode') -> 'ListNode':
        if leftHead is None: return rightHead
        if rightHead is None: return leftHead
        leftCursor = leftHead
        rightCursor = rightHead
        dummy = ListNode(0)
        cursor = dummy
        while (leftCursor is not None and rightCursor is not None):
            if leftCursor.val < rightCursor.val:
                cursor.next = leftCursor
                leftCursor = leftCursor.next
            else:
                cursor.next = rightCursor
                rightCursor = rightCursor.next
            cursor = cursor.next
        if leftCursor is None:
            cursor.next = rightCursor
        if rightCursor is None:
            cursor.next = leftCursor
        return dummy.next
        