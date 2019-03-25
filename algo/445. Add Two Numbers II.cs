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
        if (l1 == null) {
            return l2;
        }
        if (l2 == null) {
            return l1;
        }
        
        // reverse l1
        ListNode prev = null;
        ListNode curr = l1;
        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        ListNode c1 = prev;
        // reverse l2
        prev = null;
        curr = l2;
        while (curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        ListNode c2 = prev;
        
        bool ifPlusOne = false;
        int val = c1.val + c2.val;
        if (val >= 10) {
            ifPlusOne = true;
        }
        curr = new ListNode((c1.val+c2.val)%10);
        ListNode trackCurr = curr;
        c1 = c1.next;
        c2 = c2.next;
        while (c1 != null || c2 != null) {
            int v1 = c1 == null ? 0 : c1.val;
            int v2 = c2 == null ? 0 : c2.val;
            val = ifPlusOne == true ? v1 + v2 + 1 : v1 + v2;
            if (val >= 10) {
                ifPlusOne = true;
                val %= 10;
            } else {
                ifPlusOne = false;
            }
            curr = new ListNode(val);
            curr.next = trackCurr;
            trackCurr = curr;
            c1 = c1==null ? null : c1.next;
            c2 = c2==null ? null : c2.next;
        }
        
        if (ifPlusOne) {
            curr = new ListNode(1);
            curr.next = trackCurr;
        }
        return curr;
    }
}