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
    public IList<int> res;
    public IList<int> InorderTraversal(TreeNode root) {
        res = new List<int>();
        Helper(root);
        return res;
    }
    public void Helper(TreeNode root) {
        if (root == null) {
            return;
        }
        Helper(root.left);
        res.Add(root.val);
        Helper(root.right);
    }
}