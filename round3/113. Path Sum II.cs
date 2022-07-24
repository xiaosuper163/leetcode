/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var res = new List<IList<int>>();
        if (root == null) return res;
        DFSHelper(root, targetSum, new List<int>(), res);
        return res;
    }
    
    private void DFSHelper(TreeNode root, int targetSum, IList<int> currRes, IList<IList<int>> res) {
        currRes.Add(root.val);
        if (root.left == null && root.right == null) {
            if (root.val == targetSum) {
                res.Add(new List<int>(currRes));
            }
            currRes.RemoveAt(currRes.Count - 1);
            return;
        }        
        
        if (root.left != null) DFSHelper(root.left, targetSum - root.val, currRes, res);
        if (root.right != null) DFSHelper(root.right, targetSum - root.val, currRes, res);
        currRes.RemoveAt(currRes.Count - 1);
    }
}