/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode cursor = dummy;
        int start = m-1;
        while (start>0) {
            cursor = cursor.next;
            start--;
        }
        ListNode save = cursor.next;
        ListNode prev = cursor.next;
        ListNode curr = cursor.next.next;
        int steps = n-m;
        while (curr != null && steps > 0) {
            ListNode tmp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp;
            steps--;
        }
        cursor.next = prev;
        save.next = curr;
        return dummy.next;
    }
}