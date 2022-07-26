/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxPathSum(TreeNode root) {
        int res = int.MinValue;
        Helper(root, ref res);
        return res;
    }
    
    public int Helper(TreeNode root, ref int res) {
        if (root == null) return 0;
        int leftRes = Math.Max(Helper(root.left, ref res), 0);
        int rightRes = Math.Max(Helper(root.right, ref res), 0);
        res = Math.Max(res, leftRes + rightRes + root.val);
        
        return Math.Max(leftRes, rightRes) + root.val;
    }
}