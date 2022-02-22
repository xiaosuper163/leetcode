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
    public IList<string> BinaryTreePaths(TreeNode root) {
        // exit
        if (root == null) return new List<string>();
        if (root.left == null && root.right == null) return new List<string>{$"{root.val}"}; 
        
        // divide
        var left = BinaryTreePaths(root.left);
        var right = BinaryTreePaths(root.right);
        
        // merge
        var ret = new List<string>();
        foreach (string leftPath in left) {
            ret.Add($"{root.val}->" + leftPath);
        }
        foreach (string rightPath in right) {
            ret.Add($"{root.val}->" + rightPath);
        }
        
        return ret;
    }
}