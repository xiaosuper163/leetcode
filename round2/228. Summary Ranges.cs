public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        var res = new List<string>();
        if (nums.Length == 0) return res;
        bool isContinuous = false;
        int start = nums[0], end = nums[0];
        for (int i=1; i<=nums.Length; i++) {
            if (i < nums.Length && nums[i] == nums[i-1] + 1) {
                end = nums[i];
                isContinuous = true;
            } else {
                if (isContinuous) {
                    res.Add($"{start}->{end}");
                } else {
                    res.Add(start.ToString());
                }
                if (i < nums.Length) {
                    start = nums[i];
                    isContinuous = false;
                }
            }
        }
        return res;
    }
}