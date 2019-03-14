/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if (head == null) {
            return head;
        }
        ListNode oddDummy = new ListNode(0);
        ListNode evenDummy = new ListNode(0);
        ListNode oddCursor = oddDummy;
        ListNode evenCursor = evenDummy;
        ListNode cursor = head;
        int index = 1;
        while (cursor != null) {
            if (index % 2 == 1) {
                oddCursor.next = cursor;
                oddCursor = oddCursor.next;
            } else {
                evenCursor.next = cursor;
                evenCursor = evenCursor.next;
            }
            cursor = cursor.next;
            index ++;
        }
        evenCursor.next = null;
        oddCursor.next = evenDummy.next;
        return oddDummy.next;
    }
}