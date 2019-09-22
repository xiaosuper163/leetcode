public class Solution {
    public int SingleNumber(int[] nums) {
        int res = 0;
        int curr;
        for (int i=0; i<32; i++) {
            curr = 0;
            foreach (var num in nums) {
                curr += ((num >> i) & 1);
            }
            res += (curr % 3) << i;
        }
        return res;
    }
}