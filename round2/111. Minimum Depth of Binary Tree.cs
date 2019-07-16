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
    public int MinDepth(TreeNode root) {
        if (root == null) return 0;
        int lDepth = MinDepth(root.left);
        int rDepth = MinDepth(root.right);
        if (lDepth == 0) return rDepth + 1;
        if (rDepth == 0) return lDepth + 1;
        return Math.Min(lDepth, rDepth) + 1;
    }
}