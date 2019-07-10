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
    private bool Helper(TreeNode root, long min, long max) {
        if (root == null) return true;
        if (root.val <= min || root.val >= max) return false;
        return Helper(root.left, min, root.val) && Helper(root.right, root.val, max);
    }
    public bool IsValidBST(TreeNode root) {
        if (root == null) return true;
        return Helper(root.left, long.MinValue, root.val) && Helper(root.right, root.val, long.MaxValue);
    }
}