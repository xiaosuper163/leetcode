public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int? minDiff = null;
        int currSum, res=0;
        for (int i=0; i<nums.Length-2; i++) {
            int left = i+1, right = nums.Length-1;
            while (left != right) {
                currSum = nums[i]+nums[left]+nums[right];
                if (minDiff == null) {
                    minDiff = Math.Abs(target - currSum);
                    res = currSum;
                } else if (Math.Abs(target - currSum) < minDiff) {
                    minDiff = Math.Abs(target - currSum);
                    res = currSum;
                }
                if (currSum == target) {
                    return target;
                } else if (currSum < target) {
                    left ++;
                } else {
                    right --;
                }
            }
        }
        return res;
    }
}