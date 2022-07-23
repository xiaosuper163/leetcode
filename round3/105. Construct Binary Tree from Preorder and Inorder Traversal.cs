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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0) return null;
        return Helper(preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
    }
    
    private TreeNode Helper(int[] preorder, int[] inorder, int pStart, int pEnd, int iStart, int iEnd) {
        if (pStart > pEnd || iStart > iEnd) return null;
        TreeNode root = new TreeNode(preorder[pStart]);
        int idx;
        for (idx = iStart; idx <= iEnd; idx ++) {
            if (inorder[idx] == preorder[pStart]) {
                break;
            }
        }
        
        root.left = Helper(preorder, inorder, pStart + 1, pStart + idx - iStart, iStart, idx - 1);
        root.right = Helper(preorder, inorder, pEnd - iEnd + idx + 1, pEnd, idx + 1, iEnd);
        
        return root;
    }
}