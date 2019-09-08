public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        res[0] = nums[0];
        for (int i=1; i<nums.Length; i++) {
            res[i] = res[i-1] * nums[i];
        }
        int idxRight = nums.Length - 1;
        int right = 1;
        while (idxRight > 0) {
            res[idxRight] = res[idxRight-1] * right;
            right *= nums[idxRight];
            idxRight--;
        }
        res[0] = right;
        return res;
    }
}