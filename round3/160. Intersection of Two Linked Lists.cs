/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode c1 = headA, c2 = headB;
        int cnt1 = 0, cnt2 = 0;
        while (c1 != null) {
            c1 = c1.next;
            cnt1 ++;
        }
        
        while (c2 != null) {
            c2 = c2.next;
            cnt2 ++;
        }
        
        c1 = headA;
        c2 = headB;
        
        while (cnt1 > cnt2) {
            c1 = c1.next;
            cnt1 --;
        }
        
        while (cnt1 < cnt2) {
            c2 = c2.next;
            cnt2 --;
        }
        
        while (c1 != c2 && c1 != null) {
            c1 = c1.next;
            c2 = c2.next;
        }
        
        return c1;
    }
}