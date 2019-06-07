/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode cursor = dummy;
        bool carry = false;
        while (l1 != null || l2 != null) {
            int v1 = l1 == null ? 0 : l1.val;
            int v2 = l2 == null ? 0 : l2.val;
            if (carry) {
                cursor.next = new ListNode((v1+v2+1)%10);
                if (v1 + v2 >= 9) {
                    carry = true;
                } else {
                    carry = false;   
                }
            } else {
                cursor.next = new ListNode((v1+v2)%10);
                if (v1 + v2 >= 10) {
                    carry = true;
                } else {
                    carry = false;   
                }
            }
            l1 = l1 == null ? null : l1.next;
            l2 = l2 == null ? null : l2.next;
            cursor = cursor.next;
        }
        if (carry) {
            cursor.next = new ListNode(1);
        }
        return dummy.next;
    }
}