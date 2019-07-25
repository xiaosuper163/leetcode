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
        Node start = root, curr;
        while (start.left != null) {
            curr = start;
            curr.left.next = curr.right;
            while (curr.next != null) {
                curr.right.next = curr.next.left;
                curr = curr.next;
                curr.left.next = curr.right;
            }
            start = start.left;
        }
        return root;
    }
}