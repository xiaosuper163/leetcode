public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 2) return nums.Length;
        int count = 1;
        int pre = 0, curr = 1;
        while (curr < nums.Length) {
            if (nums[pre] == nums[curr] && count > 0) {
                count--;
                nums[pre+1] = nums[curr];
                pre++;
                curr++;
            } else if (nums[pre] == nums[curr]) {
                if (curr+1<nums.Length) nums[pre+1] = nums[curr+1];
                curr++;
            } else {
                count = 1;
                nums[pre+1] = nums[curr];
                pre++;
                curr++;
            }
        }
        return pre+1;
    }
}