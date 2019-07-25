/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node(){}
    public Node(int _val,Node _left,Node _right,Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
}
*/
public class Solution {
    public Node Connect(Node root) {
        if (root == null) return null;
        Node dummy = new Node(0, null, null, null);
        Node start = root, curr = dummy;
        while (start != null) {
            if (start.left != null) {
                curr.next = start.left;
                curr = curr.next;
            }
            if (start.right != null) {
                curr.next = start.right;
                curr = curr.next;
            }
            if (start.next == null) { // go to the next level
                start = dummy.next;
                curr = dummy;
                dummy.next = null; // reset curr.next
            } else {
                start = start.next;
            }
        }
        return root;
    }
}