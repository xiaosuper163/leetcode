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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode pre = dummy, curr = head;
        while (curr != null) {
            if (curr.val == val) {
                pre.next = curr.next;
                curr = curr.next;
            } else {
                pre = pre.next;
                curr = curr.next;
            }
        }
        
        return dummy.next;
    }
}