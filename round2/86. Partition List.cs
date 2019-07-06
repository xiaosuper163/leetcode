/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x) {
        ListNode dummy1 = new ListNode(0);
        ListNode dummy2 = new ListNode(0);
        ListNode c1 = dummy1, c2 = dummy2, c = head;
        while (c != null) {
            if (c.val < x) {
                c1.next = c;
                c1 = c1.next;
            } else {
                c2.next = c;
                c2 = c2.next;
            }
            c = c.next;
        }
        c1.next = dummy2.next;
        c2.next = null;
        return dummy1.next;
    }
}