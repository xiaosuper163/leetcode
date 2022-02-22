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
    public bool IsBalanced(TreeNode root) {
        if (Helper(root) == -1) {
            return false;
        } else {
            return true;
        }
    }
    
    // returns -1 if not balanced, height otherwise
    public int Helper(TreeNode root) {
        // exit
        if (root == null) return 0;
        
        // divide
        int leftRes = Helper(root.left);
        int rightRes = Helper(root.right);
        
        // merge
        if (leftRes == -1 || rightRes == -1 || Math.Abs(rightRes-leftRes) > 1) {
            return -1;
        } else {
            return Math.Max(leftRes, rightRes) + 1;
        }   
    }
}