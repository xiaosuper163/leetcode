public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int pivot;
        if (nums.Length > 2) pivot = nums[2];
        else pivot = nums[0];
        var left = new List<int>();
        var mid = new List<int>();
        var right = new List<int>();
        foreach (var num in nums) {
            if (num < pivot) left.Add(num);
            else if (num > pivot) right.Add(num);
            else mid.Add(num);
        }
        if (k <= right.Count) {
            return FindKthLargest(right.ToArray(), k);
        } else if (k - right.Count <= mid.Count) {
            return pivot;
        } else {
            return FindKthLargest(left.ToArray(), k-mid.Count-right.Count);
        }
    }
}