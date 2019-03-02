// Dynamic Programming

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
    public IList<TreeNode> GenerateTrees(int n) {
        List<List<TreeNode>> results = new List<List<TreeNode>>();
        results.Add(new List<TreeNode>());
        if (n == 0) {
            return results[0];
        }
        
        results[0].Add(null);
        for (int i = 1; i < n+1; i++) {             // fill up the results list
            List<TreeNode> temp = new List<TreeNode>();  // initialize results[i]
            for (int j = 1; j <= i; j++) {          // when j is the root of the tree
                foreach (TreeNode leftNode in results[j-1]) {
                    foreach (TreeNode rightNode in results[i-j]) {
                        TreeNode root = new TreeNode(j);
                        root.left = leftNode;
                        root.right = clone(rightNode, j);
                        temp.Add(root);
                    }
                }
            }
            results.Add(temp);
        }
        return results[n];
    }
    
    public TreeNode clone(TreeNode node, int offset) {
        if (node == null) {
            return null;
        }
        TreeNode newNode = new TreeNode(node.val + offset);
        newNode.left = clone(node.left, offset);
        newNode.right = clone(node.right, offset);
        return newNode;
    }
}