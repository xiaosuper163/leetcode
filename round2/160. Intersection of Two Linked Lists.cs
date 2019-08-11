/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode cursor1 = headA, cursor2 = headB;
        int len1 = 0, len2 = 0;
        while (cursor1 != null) {
            len1++;
            cursor1 = cursor1.next;
        }
        while (cursor2 != null) {
            len2++;
            cursor2 = cursor2.next;
        }
        cursor1 = headA;
        cursor2 = headB;
        if (len1 < len2) {
            while (len1 != len2) {
                len1++;
                cursor2 = cursor2.next;
            }
        } else {
            while (len1 != len2) {
                len2++;
                cursor1 = cursor1.next;
            }
        }
        while (cursor1 != null && cursor2 != null) {
            if (cursor1 == cursor2) return cursor1;
            cursor1 = cursor1.next;
            cursor2 = cursor2.next;
        }
        return null;
    }
}