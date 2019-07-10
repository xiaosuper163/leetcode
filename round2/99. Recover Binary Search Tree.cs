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
    private void Helper(TreeNode root, List<int> valueList, List<TreeNode> nodeList) {
        if (root == null) return;
        Helper(root.left, valueList, nodeList);
        valueList.Add(root.val);
        nodeList.Add(root);
        Helper(root.right, valueList, nodeList);
    }
    public void RecoverTree(TreeNode root) {
        var valueList = new List<int>();
        var nodeList = new List<TreeNode>();
        Helper(root, valueList, nodeList);
        valueList.Sort();
        for (int i=0; i<nodeList.Count; i++) {
            nodeList[i].val = valueList[i];
        }
    }
}