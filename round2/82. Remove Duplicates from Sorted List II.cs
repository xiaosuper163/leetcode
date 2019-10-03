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
        if (head == null || head.next == null) return head;
        ListNode dummy = new ListNode(0);
        ListNode c1 = dummy, c2 = head, c3 = head.next;
        while (c2 != null) {
            if (c2.next == null) {
                c1.next = c2;
                c1 = c1.next;
                break;
            } else if (c2.val != c3.val) {
                c1.next = c2;
                c2 = c3;
                c3 = c3.next;
                c1 = c1.next;
            } else {
                while (c3 != null && c3.val == c2.val) {
                    c3 = c3.next;
                }
                c2 = c3;
                if (c3 == null) break;
                c3 = c3.next;
            }
        }
        c1.next = null;
        return dummy.next;
    }
}

/*
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null || head.next == null) return head;
        var dummy = new ListNode(0);
        var cursor = head;
        var idxCursor = dummy;
        ListNode pre = null;
        int cnt = 1;
        while (cursor != null) {
            if (pre == null || cursor.val != pre.val) {
                if (cnt <= 1 && pre != null) {
                    idxCursor.next = pre;
                    idxCursor = idxCursor.next;
                }
                pre = cursor;
                cnt = 1;
            } else {
                cnt++;
            }
            cursor = cursor.next;
        }
        if (cnt <= 1) idxCursor.next = pre;
        else idxCursor.next = null;
        return dummy.next;
    }
}
*/