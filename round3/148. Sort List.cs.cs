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
    public ListNode SortList(ListNode head) {
        if (head == null || head.next == null) return head;
        
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode slow = dummy, fast = dummy;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        ListNode head2 = slow.next;
        slow.next = null;
        
        ListNode h1 = SortList(head);
        ListNode h2 = SortList(head2);
        
        ListNode pre = dummy;
        while (h1 != null || h2 != null) {
            if (h1 != null && h2 != null) {
                if (h1.val < h2.val) {
                    pre.next = h1;
                    h1 = h1.next;
                } else {
                    pre.next = h2;
                    h2 = h2.next;
                }
            } else {
                if (h1 != null) {
                    pre.next = h1;
                    h1 = h1.next;
                }
                if (h2 != null) {
                    pre.next = h2;
                    h2 = h2.next;
                }
            }
            
            pre = pre.next;
        }
        
        return dummy.next;
    }
}