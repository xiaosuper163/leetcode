/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseSingleGroup(ListNode head, int k) {
        ListNode n1 = head.next;
        ListNode nknext = head.next;
        for (int i=0; i<k; i++) {
            if (nknext == null) return null;
            nknext = nknext.next;
        }
        
        ListNode prev = head.next;
        ListNode curr = prev.next;
        
        for (int i=0; i<k-1; i++) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        
        head.next = prev;
        n1.next = nknext;
        
        return n1;
    }
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode dummy = new ListNode(-1);
        dummy.next = head;
        head = dummy;      
        while (head != null) {
            head = ReverseSingleGroup(head, k);
        }
        return dummy.next;
    }
}