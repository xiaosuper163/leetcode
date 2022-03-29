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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var dummy = new ListNode();
        bool addOne = false;
        ListNode cursor = dummy;
        ListNode cursor1 = l1;
        ListNode cursor2 = l2;
        while (cursor1 != null && cursor2 != null) {
            int currVal = cursor1.val + cursor2.val;
            if (addOne)
                currVal ++;
            if (currVal > 9) {
                addOne = true;
                currVal %= 10;
            } else {
                addOne = false;
            }
            cursor.next = new ListNode(currVal);
            cursor = cursor.next;
            
            cursor1 = cursor1.next;
            cursor2 = cursor2.next;
        }
        
        ListNode cursor3;
        if (cursor1 != null) {
            cursor3 = cursor1;
        } else {
            cursor3 = cursor2;
        }
        
        while (cursor3 != null) {
            int currVal = addOne ? cursor3.val + 1 : cursor3.val;
            if (currVal > 9) {
                addOne = true;
                currVal %= 10;
            } else {
                addOne = false;
            }
            cursor.next = new ListNode(currVal);
            cursor = cursor.next;
            
            cursor3 = cursor3.next;
        }
        
        if (addOne) {
            cursor.next = new ListNode(1);
        }
        
        return dummy.next;
    }
}