public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var m = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i ++) {
            int num = nums[i];
            if (m.ContainsKey(num)) {
                if (i - m[num] <= k) return true;
                else
                    m[num] = i;
            } else {
                m[num] = i;
            }
        }
        return false;
    }
}