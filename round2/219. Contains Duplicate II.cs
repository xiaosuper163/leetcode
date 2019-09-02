public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var m = new Dictionary<int, int>();
        for (int i=0; i<nums.Length; i++) {
            if (m.ContainsKey(nums[i]) && i-m[nums[i]]<=k) return true;
            m[nums[i]] = i;
        }
        return false;
    }
}