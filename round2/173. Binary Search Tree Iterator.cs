/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class BSTIterator {
    private Stack<TreeNode> st;
    
    public BSTIterator(TreeNode root) {
        st = new Stack<TreeNode>();
        while(root != null) {
            st.Push(root);
            root = root.left;
        }
    }
    
    /** @return the next smallest number */
    public int Next() {
        TreeNode curr = st.Pop();
        int res = curr.val;
        curr = curr.right;
        while(curr != null) {
            st.Push(curr);
            curr = curr.left;
        }
        return res;
    }
    
    /** @return whether we have a next smallest number */
    public bool HasNext() {
        if (st.Count == 0) return false;
        return true;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */