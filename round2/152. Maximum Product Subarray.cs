public class Solution {
    public int MaxProduct(int[] nums) {
        int preMax = nums[0], preMin = nums[0], res = nums[0];
        for (int i=1; i<nums.Length; i++) {
            int curr1 = preMax * nums[i];
            int curr2 = preMin * nums[i];
            preMax = Math.Max(nums[i], Math.Max(curr1, curr2));
            preMin = Math.Min(nums[i], Math.Min(curr1, curr2));
            res = Math.Max(res, Math.Max(preMax, preMin));
        }
        return res;
    }
}