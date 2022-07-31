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
    public void ReorderList(ListNode head) {
        // split the list into 2 with similar size
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode slow = dummy, fast = dummy;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }      
        
        ListNode cursor2 = slow.next;
        slow.next = null;
        ListNode cursor1 = head;
        
        // reverse the 2nd list
        ListNode pre2 = null;
        while (cursor2 != null) {
            ListNode tmp = cursor2.next;
            cursor2.next = pre2;
            pre2 = cursor2;
            cursor2 = tmp;
        }
        cursor2 = pre2;
        
        // merge
        while (cursor1 != null && cursor2 != null) {
            ListNode tmp1 = cursor1.next, tmp2 = cursor2.next;
            cursor1.next = cursor2;
            cursor2.next = tmp1;
            cursor1 = tmp1;
            cursor2 = tmp2;
        }
        
    }
}