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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var dummy = new ListNode();
        ListNode preLeft = dummy;
        dummy.next = head;
        
        int i = 0;
        while (i < left - 1) {
            preLeft = preLeft.next;
            i ++;
        }
        
        ListNode preRight = preLeft.next;
        ListNode pre = preLeft.next;
        ListNode curr = pre.next;
        
        while (i < right - 1) {
            ListNode tmp = curr.next;
            curr.next = pre;
            pre = curr;
            curr = tmp;
            i ++;
        }
        
        preLeft.next = pre;
        preRight.next = curr;
        
        return dummy.next;
    }
}