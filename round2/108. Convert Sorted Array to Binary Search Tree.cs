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
    private TreeNode Helper(int[] nums, int start, int end) {
        if (start > end) return null;
        if (start == end) return new TreeNode(nums[start]);
        int mid = (end-start) / 2 + start;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = Helper(nums, start, mid-1);
        root.right = Helper(nums, mid+1, end);
        return root;
    }
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length == 0) return null;
        return Helper(nums, 0, nums.Length-1); 
    }
}