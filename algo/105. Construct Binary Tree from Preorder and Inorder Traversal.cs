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
    public Dictionary<int, int> dict;
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder == null || preorder.Length == 0) {
            return null;
        }
        dict = new Dictionary<int, int>();
        for (int i = 0; i < inorder.Length; i++) {
            dict[inorder[i]] = i;
        }
        return Helper(0, 0, preorder.Length-1, preorder, inorder);
    }
    public TreeNode Helper(int rootIndex, int startIndex, int endIndex, int[] preorder, int[] inorder) {
        if (rootIndex > preorder.Length - 1 || startIndex > endIndex) {
            return null;
        }
        TreeNode root = new TreeNode(preorder[rootIndex]);
        int inIndex = dict[preorder[rootIndex]];
        root.left = Helper(rootIndex+1, startIndex, inIndex-1, preorder, inorder);
        root.right = Helper(rootIndex+inIndex-startIndex+1, inIndex+1, endIndex, preorder, inorder);
        return root;
    }
}
