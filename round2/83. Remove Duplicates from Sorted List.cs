/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null) return head;
        ListNode dummy = new ListNode(0);
        ListNode c1 = head, c2 = head.next;
        dummy.next = c1;
        while (c2 != null) {
            if (c1.val != c2.val) {
                c1.next = c2;
                c1 = c1.next;
                c2 = c2.next;
            } else {
                c2 = c2.next;
            }
        }
        c1.next = null;
        return dummy.next;
    }
}