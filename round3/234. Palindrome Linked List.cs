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
    public bool IsPalindrome(ListNode head) {
        ListNode dummy = new ListNode();
        dummy.next = head;
        ListNode slow = dummy, fast = dummy;
        var st = new Stack<int>();
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
            if (slow != null) st.Push(slow.val);
        }
        
        if (fast == null) st.Pop(); // odd number of nodes
        ListNode cursor = slow.next;
        while (st.Count != 0) {
            int curr = st.Pop();
            if (curr != cursor.val) return false;
            cursor = cursor.next;
        }
        
        return true;
    }
}