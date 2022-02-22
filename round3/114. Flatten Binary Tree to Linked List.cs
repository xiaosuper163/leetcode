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
    public void Flatten(TreeNode root) {
        Helper(root);
    }
    
    // returns bottom right leaf
    public TreeNode Helper(TreeNode root) {
        if (root == null) return null;
        // leaf
        if (root.left == null && root.right == null) {
            return root;
        }
        
        // divide
        TreeNode leftRes = Helper(root.left);
        TreeNode rightRes = Helper(root.right);
        
        // merge        
        if (leftRes == null) return rightRes;
        leftRes.right = root.right;
        root.right = root.left;
        root.left = null; // very important to null the left child pointer
        
        return rightRes == null ? leftRes : rightRes;
    }
}