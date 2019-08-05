/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null) return;
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode mid = slow.next;
        slow.next = null;
        ListNode pre = null, curr = mid;
        while (curr != null) {
            ListNode tmp = curr.next;
            curr.next = pre;
            pre = curr;
            curr = tmp;
        }
        
        ListNode p1 = head, p2 = pre;
        while (p1 != null && p2 != null) {
            //Console.WriteLine($"{p1.val} {p2.val}");
            ListNode tmp2 = p1.next, tmp3 = p2.next;
            p1.next = p2;
            p2.next = tmp2;
            p1 = tmp2;
            p2 = tmp3;
        }
    }
}