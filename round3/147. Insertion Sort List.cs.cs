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
    public ListNode InsertionSortList(ListNode head) {
        ListNode cursor1 = head, cursor2 = head;
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode pre1 = dummy, pre2 = dummy;
        
        while (cursor1 != null) {
            while (cursor2 != cursor1) {
                if (cursor2.val >= cursor1.val) {
                    pre1.next = cursor1.next;
                    pre2.next = cursor1;
                    cursor1.next = cursor2;
                    cursor1 = pre1;
                    break;
                }
                
                pre2 = pre2.next;
                cursor2 = cursor2.next;
            }
            
            pre1 = cursor1;
            cursor1 = cursor1.next;
            
            pre2 = dummy;
            cursor2 = dummy.next; // note: don't assign head to cursor2. head might have been moved to the middle     
        }
        
        return dummy.next;
    }
}