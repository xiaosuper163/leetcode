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
    public int KthSmallest(TreeNode root, int k) {
        var l = new List<int>();
        Helper(root, l);
        return l[k-1];
    }
    public void Helper(TreeNode root, List<int> l) {
        if (root == null) {
            return;
        } else {
            Helper(root.left, l);
            l.Add(root.val);
            Helper(root.right, l);
        }
    }
}