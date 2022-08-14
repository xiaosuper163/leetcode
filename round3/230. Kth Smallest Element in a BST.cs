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
    public int KthSmallest(TreeNode root, int k) {
        var lst = new List<int>();
        Inorder(root, lst);
        return lst[k - 1];
    }
    
    private void Inorder(TreeNode root, IList<int> lst) {
        if (root == null) return;
        Inorder(root.left, lst);
        lst.Add(root.val);
        Inorder(root.right, lst);
    }
}