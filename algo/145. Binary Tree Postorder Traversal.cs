// Iterative solution of postorder traversal

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

// Recursive implementation
/*
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        Helper(root, res);
        return res;
    }
    
    public void Helper (TreeNode root, IList<int> res) {
        if (root == null) {
            return;
        }
        Helper(root.left, res);
        Helper(root.right, res);
        res.Add(root.val);
    }
}
*/

public struct Pair
{
    public TreeNode node;
    public bool visited;
    public Pair(TreeNode n, bool v)
    {
        node = n;
        visited = v;
    }
}

// Iterative implementation
public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        TreeNode p = root;
        Stack<Pair> st = new Stack<Pair>();
        Pair pair;
        
        while (p != null || st.Count != 0) {
            while (p != null) {
                pair = new Pair(p, false);
                st.Push(pair);
                p = p.left;
            }
            if (st.Count != 0) {
                Pair tempPair = st.Pop();
                if (!tempPair.visited) {
                    tempPair.visited = true;
                    st.Push(tempPair);
                    p = tempPair.node.right;
                } else {
                    res.Add(tempPair.node.val);
                    p = null;
                }
            }
        }
        
        return res;
    }

}