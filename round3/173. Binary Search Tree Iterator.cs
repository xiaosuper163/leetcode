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
public class BSTIterator {
    
    private Stack<TreeNode> st;

    public BSTIterator(TreeNode root) {
        st = new Stack<TreeNode>();
        while (root != null) {
            st.Push(root);
            root = root.left;
        }
    }
    
    public int Next() {
        var curr = st.Pop();
        if (curr.right != null) {
            TreeNode root = curr.right;
            while (root != null) {
                st.Push(root);
                root = root.left;
            }
        }
        return curr.val;
    }
    
    public bool HasNext() {
        return st.Count > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */