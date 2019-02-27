// Divide and Conquer

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
    public int maxPathSumValue;
    
    public int MaxPathSum(TreeNode root) {
        maxPathSumValue = int.MinValue;
        Helper(root);
        return maxPathSumValue;
    }
    public int Helper(TreeNode node) {
        if (node == null) {
            return 0;
        }
        int leftMax = Math.Max(0, Helper(node.left));
        int rightMax = Math.Max(0, Helper(node.right));
        maxPathSumValue = Math.Max(maxPathSumValue, leftMax+rightMax+node.val);
        return Math.Max(leftMax, rightMax) + node.val;
    }
}