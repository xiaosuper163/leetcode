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
    public ListNode Partition(ListNode head, int x) {
        ListNode cursor = head;
        ListNode dummy1 = new ListNode();
        ListNode left = dummy1;
        ListNode dummy2 = new ListNode();
        ListNode right = dummy2;
        
        while (cursor != null) {
            if (cursor.val < x) {
                left.next = cursor;
                left = left.next;
            } else {
                right.next = cursor;
                right = right.next;
            }
            cursor = cursor.next;
        }
        
        left.next = dummy2.next;
        right.next = null;
        return dummy1.next;            
    }
}