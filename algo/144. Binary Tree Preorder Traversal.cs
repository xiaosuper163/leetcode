// Iterative implementation of preorder traversal

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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode p = root;
        while (p != null || st.Count != 0) {
            while (p != null) {
                res.Add(p.val);
                st.Push(p);
                p = p.left;
            }
            
            if (st.Count != 0) {
                p = st.Pop();
                p = p.right;
            }
        }
        return res;
    }
}