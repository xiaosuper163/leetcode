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
    private List<TreeNode> Helper(int start, int end) {
        var res = new List<TreeNode>();
        if (start > end) {
            res.Add(null);
            return res;
        }
        for (int i=start; i<=end; i++) {
            var leftRes = Helper(start, i-1);
            var rightRes = Helper(i+1, end);
            foreach(var leftRoot in leftRes) {
                foreach(var rightRoot in rightRes) {
                    TreeNode root = new TreeNode(i);
                    root.left = leftRoot;
                    root.right = rightRoot;
                    res.Add(root);
                }
            }
        }
        return res;
    }
    public IList<TreeNode> GenerateTrees(int n) {
        if (n==0) return new List<TreeNode>();
        var res = Helper(1, n);
        return res;
    }
}