public class Solution {
    public int MajorityElement(int[] nums) {
        int cnt = 1, curr = nums[0];
        
        for (int i = 1; i < nums.Length; i ++) {
            if (nums[i] == curr) {
                cnt ++;
            } else {
                cnt --;
                
                if (cnt == 0) {
                    curr = nums[i + 1];
                }
            }
        }
        
        return curr;
    }
}