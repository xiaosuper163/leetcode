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
    public TreeNode SortedArrayToBST(int[] nums) {
        return Helper(nums, 0, nums.Length - 1);
    }
    
    private TreeNode Helper(int[] nums, int start, int end) {
        if (end < start) return null;
        
        int mid = (end - start) / 2 + start;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = Helper(nums, start, mid - 1);
        root.right = Helper(nums, mid + 1, end);
        return root;
    }
}