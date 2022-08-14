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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null) return null;
        if (root == p || root == q) return root;
        TreeNode leftRes = LowestCommonAncestor(root.left, p, q);
        TreeNode rightRes = LowestCommonAncestor(root.right, p, q);
        if (leftRes != null && rightRes != null) return root;
        if (leftRes != null) return leftRes;
        if (rightRes != null) return rightRes;
        return null;
    }
}

// 3
// 1 4
// 2