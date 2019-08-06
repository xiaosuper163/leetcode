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
    public IList<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        if (root == null) return res;
        TreeNode head = root;
        var st = new Stack<TreeNode>();
        st.Push(root);
        while (st.Count != 0) {
            TreeNode curr = st.Peek();
            if ((curr.left == null && curr.right == null) || curr.left == head || curr.right == head) {
                res.Add(curr.val);
                st.Pop();
                head = curr;
            } else {
                if (curr.right != null) st.Push(curr.right);
                if (curr.left != null) st.Push(curr.left);
            }
        }
        return res;
    }
}