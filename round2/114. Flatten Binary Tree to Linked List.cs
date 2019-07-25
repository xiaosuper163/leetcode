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
    private Tuple<TreeNode, TreeNode> Helper(TreeNode root) {
        if (root == null) return new Tuple<TreeNode, TreeNode>(null, null);
        if (root.left == null && root.right == null) return new Tuple<TreeNode, TreeNode>(root, root);
        var (leftHead, leftTail) = Helper(root.left);
        var (rightHead, rightTail) = Helper(root.right);
        if (leftHead == null) {
            root.left = null;
            root.right = rightHead;
            return new Tuple<TreeNode, TreeNode>(root, rightTail);
        }
        if (rightHead == null) {
            root.right = leftHead;
            root.left = null;
            return new Tuple<TreeNode, TreeNode>(root, leftTail);
        }
        root.right = leftHead;
        root.left = null;
        leftTail.right = rightHead;
        return new Tuple<TreeNode, TreeNode>(root, rightTail);        
    }
    public void Flatten(TreeNode root) {
        var (res, _) = Helper(root);
    }
}