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
    public void RecoverTree(TreeNode root) {
        var nodeList = new List<TreeNode>();
        var valList = new List<int>();
        InorderTraverse(root, nodeList, valList);
        valList.Sort();
        for (int i = 0; i < valList.Count; i ++) {
            nodeList[i].val = valList[i];
        }
    }
    
    private void InorderTraverse(TreeNode root, IList<TreeNode> nodeList, IList<int> valList) {
        if (root == null) return;
        InorderTraverse(root.left, nodeList, valList);
        nodeList.Add(root);
        valList.Add(root.val);
        InorderTraverse(root.right, nodeList, valList);
    }
}