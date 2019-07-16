/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        if (head == null) return null;
        if (head.next == null) return new TreeNode(head.val);
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            dummy = dummy.next;
            slow = slow.next;
            fast = fast.next.next;;
        }
        TreeNode root = new TreeNode(slow.val);
        //Console.WriteLine(slow.val);
        dummy.next = null;
        slow = slow.next;       
        root.left = SortedListToBST(head);
        root.right = SortedListToBST(slow);
        return root;
    }
}