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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        return Helper(inorder, postorder, 0, inorder.Length - 1, 0, postorder.Length - 1);
    }
    
    private TreeNode Helper(int[] inorder, int[] postorder, int iStart, int iEnd, int pStart, int pEnd) {
        if (iEnd - iStart < 0 || pEnd - pStart < 0) return null;
        TreeNode root = new TreeNode(postorder[pEnd]);
        
        int idx;
        for (idx = iStart; idx <= iEnd; idx ++) {
            if (inorder[idx] == postorder[pEnd]) break;
        }
        
        root.left = Helper(inorder, postorder, iStart, idx - 1, pStart, pStart + idx - iStart - 1);
        root.right = Helper(inorder, postorder, idx + 1, iEnd, pEnd - iEnd + idx, pEnd - 1);
        
        return root;
    }
}