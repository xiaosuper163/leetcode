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
    public int SumNumbers(TreeNode root) {
        int res = 0;
        Helper(root, 0, ref res);
        return res;
    }
    
    private void Helper(TreeNode root, int currRes, ref int res) {
        if (root == null) {
            return;
        }
        
        int curr = currRes * 10 + root.val;        
        if (root.left == null && root.right == null) {
            res += curr;
        }        
        
        Helper(root.left, curr, ref res);
        Helper(root.right, curr, ref res);
    }
}