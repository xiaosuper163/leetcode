public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var res = new int[nums.Length];
        res[0] = 1;
        for (int i = 1; i < nums.Length; i ++) {
            res[i] = res[i-1] * nums[i-1];
        }
        
        int tmp = 1;
        for (int i = nums.Length - 2; i >= 0; i --) {
            tmp *= nums[i + 1];
            res[i] = res[i] * tmp;
        }
        
        return res;
    }
}