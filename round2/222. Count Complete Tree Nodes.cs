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
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        var left = root.left;
        var right = root.right;
        int lh = 1, rh = 1;
        while (left != null) {
            lh++;
            left = left.left;
        }
        while (right != null) {
            rh++;
            right = right.right;
        }
        if (lh == rh) return (int) Math.Pow(2, lh) - 1;
        else return CountNodes(root.left) + CountNodes(root.right) + 1;
    }
}