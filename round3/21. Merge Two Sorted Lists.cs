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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode();
        ListNode cursor1 = list1, cursor2 = list2;
        ListNode cursor = dummy;
        
        while (cursor1 != null && cursor2 != null) {
            if (cursor1.val < cursor2.val) {
                cursor.next = cursor1;
                cursor1 = cursor1.next;
            } else {
                cursor.next = cursor2;
                cursor2 = cursor2.next;
            }
            cursor = cursor.next;
        }
        
        if (cursor1 != null) {
            while(cursor1 != null) {
                cursor.next = cursor1;
                cursor1 = cursor1.next;
                cursor = cursor.next;
            }
        }
        
        if (cursor2 != null) {
            while(cursor2 != null) {
                cursor.next = cursor2;
                cursor2 = cursor2.next;
                cursor = cursor.next;
            }
        }
        
        return dummy.next;
    }
}