# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None
from heapq import *

class Solution:
    def mergeKLists(self, lists: List[ListNode]) -> ListNode:
        dummy = ListNode(-1)
        cursor = dummy
        
        q = []
        for i, l in enumerate(lists):
            if l:
                heappush(q, (l.val, i))
        while (len(q) != 0):
            val, i = heappop(q)
            node = lists[i]
            cursor.next = node
            cursor = cursor.next
            lists[i] = lists[i].next
            if lists[i]:
                heappush(q, (lists[i].val, i))
        return dummy.next