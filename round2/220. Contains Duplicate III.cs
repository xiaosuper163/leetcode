public class Solution {
    public long GetBucketID(long num, long width) {
        return num < 0 ? (num + 1) / width - 1 : num / width;
    }
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (t < 0 || k < 1 || nums.Length == 0) return false;
        var buckets = new Dictionary<long, long>();
        long width = (long) t + 1;
        for (int i = 0; i < nums.Length; i++) {
            var bucketID = GetBucketID(nums[i], width);
            if (buckets.ContainsKey(bucketID)) return true;
            if (buckets.ContainsKey(bucketID-1) && Math.Abs(nums[i] - buckets[bucketID-1]) < width) return true;
            if (buckets.ContainsKey(bucketID+1) && Math.Abs(buckets[bucketID+1] - nums[i]) < width) return true;
            buckets[bucketID] = (long) nums[i];
            if (i >= k) {
                buckets.Remove(GetBucketID(nums[i-k], width));
            }
        }
        return false;
    }
}