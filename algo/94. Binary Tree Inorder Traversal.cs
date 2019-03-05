// Iterative implementation of inorder traversal

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

/* recursive implementation */
/*
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
*/

/* iterative implementation */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode p = root;
        while (p != null || st.Count != 0) {
            while (p != null) {
                st.Push(p);
                p = p.left;
            }
            
            if (st.Count != 0) {
                p = st.Pop();
                res.Add(p.val);
                p = p.right;
            }
        }
        return res;
    }
}