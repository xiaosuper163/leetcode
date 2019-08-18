public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums.Length == 0) return;
        k = k % nums.Length;
        if (k == 0) return;
        int index = 0;
        int start = 0;
        int pre = 0;
        int cur = nums[0];
        for (int dummy = 0; dummy < nums.Length; dummy++) {
            pre = cur;
            index = (index + k) % nums.Length;
            cur = nums[index];
            nums[index] = pre;            
            if (index == start) {
                index = ++start;
                cur = nums[index];
            }
        }
    }
}