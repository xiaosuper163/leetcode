/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        ListNode dummy = new ListNode(-1);
        dummy.next = head;
        ListNode c1 = dummy;
        ListNode c2 = head;
        while (c1 != null && c2 != null && c2.next != null) {
            c1.next = c2.next;
            ListNode temp = c1.next.next;
            c1.next.next = c2;
            c2.next = temp;
            c1 = c1.next.next;
            c2 = c2.next;
        }
        return dummy.next;
    }
}