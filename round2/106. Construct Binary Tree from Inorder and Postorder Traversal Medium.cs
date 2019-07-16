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
    private TreeNode Helper(int[] inorder, int iStart, int iEnd, int[] postorder, int pStart, int pEnd) {
        if (iStart>iEnd || pStart>pEnd) return null;
        TreeNode root = new TreeNode(postorder[pEnd]);
        int i;
        for (i=iStart; i<=iEnd; i++) {
            if (inorder[i] == postorder[pEnd]) break;
        }
        root.left = Helper(inorder, iStart, i-1, postorder, pStart, pStart+i-1-iStart);
        root.right = Helper(inorder, i+1, iEnd, postorder, pEnd-(iEnd-i), pEnd-1);
        return root;
    }
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        if (inorder.Length == 0) return null;
        TreeNode root = Helper(inorder, 0, inorder.Length-1, postorder, 0, postorder.Length-1);
        return root;
    }
}