/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null) return head;
        ListNode cursor = head;
        ListNode cursor2 = head;
        int size = 1;
        while (cursor.next != null) {
            cursor = cursor.next;
            size++;
        }
        cursor.next = head;
        int toCut = size - k % size - 1;
        while (toCut > 0) {
            cursor2 = cursor2.next;
            toCut--;
        }
        ListNode resHead = cursor2.next;
        cursor2.next = null;
        return resHead;
    }
}