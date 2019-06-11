public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> res = new List<IList<int>>();
        if (nums.Length < 3) return res;
        for (int min = 0; min < nums.Length; min ++) {
            if (min > 0 && nums[min] == nums[min-1]) continue;
            int left = min + 1, right = nums.Length - 1;
            while (left < right) {
                if (nums[min] + nums[left] + nums[right] > 0) {
                    right --;
                } else if (nums[min] + nums[left] + nums[right] < 0) {
                    left ++;
                } else {
                    res.Add(new List<int>() {nums[min], nums[left], nums[right]});
                    while (left + 1 < right && nums[left]==nums[left+1]) left++;
                    while (right - 1 > left && nums[right]==nums[right-1]) right--;
                    left ++;
                    right --;
                }
            }
        }
        return res;
    }
}