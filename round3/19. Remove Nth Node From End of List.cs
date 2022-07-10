/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode left = head, right = head;
        for (int i = 0; i < n; i ++) {
            right = right.next;
        }
        
        if (right == null) return head.next;
        
        while (right.next != null) {
            right = right.next;
            left = left.next;
        }
        
        left.next = left.next.next;
        return head;
    }
}