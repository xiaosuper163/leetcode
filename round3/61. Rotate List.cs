/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null) return head;
        
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode cursor = dummy;
        int len = 0;
        while (cursor.next != null) {
            len ++;
            cursor = cursor.next;
        }
        
        cursor.next = head;
        k %= len;
        
        cursor = head;
        ListNode preHead = dummy;
        for (int i = 0; i < len - k; i ++) {
            preHead = preHead.next;
            cursor = cursor.next;
        }
        
        preHead.next = null;
        return cursor;        
    }
}