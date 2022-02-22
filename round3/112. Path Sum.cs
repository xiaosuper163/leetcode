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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root == null) {
            return false;
        }
        if (root.left == null && root.right == null) {
            if (root.val == targetSum) return true;
            return false;
        }
        
        bool leftRes = HasPathSum(root.left, targetSum - root.val);
        bool rightRes = HasPathSum(root.right, targetSum - root.val);
        
        if(leftRes || rightRes) return true;
        return false;
    }
}