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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) return null;
        var newLeft = InvertTree(root.right);
        var newRight = InvertTree(root.left);
        root.left = newLeft;
        root.right = newRight;
        return root;
    }
}