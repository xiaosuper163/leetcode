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

    public int PathSum(TreeNode root, int sum) {
        if (root == null) {
            return 0;
        }
        return PathSum(root.left, sum) + PathSum(root.right, sum) + helper(root, sum);
    }
    public int helper(TreeNode root, int sum) {
        int count = 0;
        if (root.val == sum) {
            count ++;
        }
        if (root.left == null && root.right == null) {
            return count;
        }
        int left=0, right=0;
        if (root.left != null) {
            left = helper(root.left, sum-root.val);
        }
        if (root.right != null) {
            right = helper(root.right, sum-root.val);
        }
        //Console.WriteLine("This node " + root.val + " Target Sum: " + sum);
        //Console.WriteLine(count + left + right);
        return count + left + right;
    }
}