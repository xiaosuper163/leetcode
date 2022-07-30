public class Solution {
    public int SingleNumber(int[] nums) {
        int res = 0;
        
        for (int i = 0; i < 32; i ++) {
            int sum = 0;
            foreach (int num in nums) {
                sum += (num >> i) & 1;
            }
            res += (sum % 3) << i;
        }
        
        return res;
    }
}