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
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        var res = new List<IList<int>>();
        if (root == null) return res;
        if (root.left == null && root.right == null) {
            if (root.val == sum) {
                //Console.WriteLine(sum);
                res.Add(new List<int>(){root.val});
                return res;
            } else {
                return res;
            }
        }
        var leftRes = PathSum(root.left, sum-root.val);
        var rightRes = PathSum(root.right, sum-root.val);
        foreach (var lst in leftRes) {
            lst.Insert(0, root.val);
            res.Add(lst);
        }
        foreach (var lst in rightRes) {
            lst.Insert(0, root.val);
            res.Add(lst);
        }
        return res;
    }
}