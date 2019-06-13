/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode cursor = dummy;
        ListNode head1 = l1;
        ListNode head2 = l2;
        while (l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                cursor.next = l1;
                l1 = l1.next;
            } else {
                cursor.next = l2;
                l2 = l2.next;
            }
            cursor = cursor.next;
        }
        if (l1 == null) {
            cursor.next = l2;
        } else {
            cursor.next = l1;
        }
        return dummy.next;
    }
}