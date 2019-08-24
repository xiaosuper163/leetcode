/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null) return null;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode pre = dummy, curr = head;
        while (curr != null) {
            if (curr.val != val) {
                pre = curr;
                curr = curr.next;
            } else {
                pre.next = curr.next;
                curr = curr.next;
            }
        }
        return dummy.next;
    }
}