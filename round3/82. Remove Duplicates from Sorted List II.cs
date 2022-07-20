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
    public ListNode DeleteDuplicates(ListNode head) {        
        ListNode dummy = new ListNode();
        
        ListNode prev = dummy;
        ListNode curr = head;
        
        while (curr != null) {
            if (curr.next != null && curr.next.val == curr.val) {
                
                while (curr.next != null && curr.next.val == curr.val) {
                    curr = curr.next;
                }
                curr = curr.next;
            } else {
                prev.next = curr;
                curr = curr.next;
                prev = prev.next;
            } 
        }
        
        prev.next = null; // ! append null at the end
        
        return dummy.next;        
    }
}