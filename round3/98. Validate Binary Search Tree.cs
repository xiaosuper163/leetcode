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
    public bool IsValidBST(TreeNode root) {
        return Helper(root, long.MinValue, long.MaxValue);
    }
    
    public bool Helper(TreeNode root, long min, long max) {
        if (root == null) return true;
        if (root.val >= max || root.val <= min) return false;
        
        bool leftRes = Helper(root.left, min, root.val);
        bool rightRes = Helper(root.right, root.val, max);
        
        if (leftRes && rightRes) return true;
        return false;
    }
}