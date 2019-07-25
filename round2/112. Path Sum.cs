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
    private bool Helper(TreeNode root, int sum) {
        if (root == null && sum == 0) return true;
        if (root == null && sum != 0) return false;
        if (sum == root.val && root.left == null && root.right == null) return true;
        if (HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val)) return true;
        return false;
    }
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null && sum == 0) return false;
        return Helper(root, sum);
    }
}