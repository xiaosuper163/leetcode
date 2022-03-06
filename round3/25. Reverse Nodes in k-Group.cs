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
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummy = new ListNode(){next = head};
        ListNode prev = dummy;
        while (prev != null) {
            prev = ReverseOneGroup(prev, k);
        }
        return dummy.next;
    }
    
    private ListNode ReverseOneGroup(ListNode prevHead, int k) {
        ListNode curr = prevHead.next;
        int len = 0;
        while (curr != null && len < k) {
            curr = curr.next;
            len ++;
        }
        if (len < k) {
            return null;
        }
        
        len = k;
        ListNode prev = prevHead, temp = null, ret=prevHead.next;
        curr = prevHead.next;
        while (len > 0) {
            temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
            len --;
        }
        prevHead.next = prev;
        ret.next = curr;
        return ret;
    }
}