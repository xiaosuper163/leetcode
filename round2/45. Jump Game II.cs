public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length == 1) return 0;

        int currEnd = 0;
        int currMax = 0;
        int numJumps = 0;

        for (int i=0; i<nums.Length-1; i++) {
            currMax = Math.Max(nums[i]+i, currMax);
            if (i == currEnd) {
                numJumps++;
                currEnd = currMax;
            }
        }

        return numJumps;
    }
}