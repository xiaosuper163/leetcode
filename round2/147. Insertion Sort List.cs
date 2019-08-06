/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode InsertionSortList(ListNode head) {
        if (head == null) return null;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode cursor1, cursor2 = head.next;
        head.next = null;
        while (cursor2 != null) { 
            cursor1 = dummy;
            ListNode tmp = cursor2.next;
            while (cursor1 != null && cursor1.next != null && cursor2.val >= cursor1.next.val) {
                //Console.WriteLine(cursor1.next.val);
                cursor1 = cursor1.next;
            }
            cursor2.next = cursor1.next;
            cursor1.next = cursor2;
            cursor2 = tmp;
        }
        return dummy.next;
    }
}