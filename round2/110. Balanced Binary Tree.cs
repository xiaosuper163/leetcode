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
    private int Helper(TreeNode root) {
        if (root == null) return 0;
        int lHeight = Helper(root.left);
        int rHeight = Helper(root.right);
        if (lHeight == -1 || rHeight == -1 || lHeight + 1 < rHeight || rHeight + 1 < lHeight) return -1;
        return Math.Max(lHeight, rHeight) + 1;
    }
    public bool IsBalanced(TreeNode root) {
        if (Helper(root) == -1) return false;
        return true;
    }
}