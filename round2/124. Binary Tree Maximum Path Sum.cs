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
    private int Helper(TreeNode root, ref int res) {
        if (root == null) return 0;
        int leftRes = Helper(root.left, ref res);
        int rightRes = Helper(root.right, ref res);
        res = Math.Max(res, root.val);
        res = Math.Max(Math.Max(res, leftRes + rightRes + root.val), Math.Max(leftRes + root.val, rightRes + root.val));
        return Math.Max(leftRes, rightRes) > 0 ? Math.Max(leftRes, rightRes) + root.val : root.val;
    }
    public int MaxPathSum(TreeNode root) {
        int res = int.MinValue;
        Helper(root, ref res);
        return res;
    }
}