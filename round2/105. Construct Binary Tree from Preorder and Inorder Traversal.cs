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
    private TreeNode Helper(int[] preorder, int pStart, int pEnd, int[] inorder, int iStart, int iEnd) {
        if (pStart > pEnd || iStart > iEnd) return null;
        TreeNode curr = new TreeNode(preorder[pStart]);
        int rootIndex;
        for (rootIndex=iStart; rootIndex<iEnd; rootIndex++) {
            if (inorder[rootIndex] == curr.val) break;
        }
        curr.left = Helper(preorder, pStart+1, rootIndex-iStart+pStart, inorder, iStart, rootIndex-1);
        curr.right = Helper(preorder, rootIndex-iStart+pStart+1, pEnd, inorder, rootIndex+1, iEnd);
        return curr;
    }
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0) return null;
        return Helper(preorder, 0, preorder.Length-1, inorder, 0, inorder.Length-1);
    }
}