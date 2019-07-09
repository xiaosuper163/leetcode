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
    private void Helper(TreeNode root, List<int> res) {
        if (root == null) return;
        Helper(root.left, res);
        res.Add(root.val);
        Helper(root.right, res);
    }
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();
        Helper(root, res);
        return res;
    }
}